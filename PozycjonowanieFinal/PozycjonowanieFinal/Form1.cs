using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basler.Pylon;
using Aerotech.A3200;
using Aerotech.A3200.Exceptions;
using Aerotech.A3200.Status;
using Aerotech.A3200.Variables;
using Aerotech.A3200.Tasks;
using Aerotech.A3200.Information;
using Aerotech.Common;
using Aerotech.Common.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Imaging;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace PozycjonowanieFinal
{
    public partial class Form1 : Form
    {
        private Controller myController;
        int axisIndex;
        int taskIndex;
        private Camera camera = null;
        private PixelDataConverter converter = new PixelDataConverter();
        private Stopwatch stopWatch = new Stopwatch();
        private int wyjscie;
        private int wart = 10;

        public Form1()
        {
            InitializeComponent();
        }
        private void chkBox_Serw_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chkBox_Cam.Checked = false;
            chkBox_Serw.Checked = false;
            EnableAxisContols(false);
            EnableCameraControls(false);
            EnableAutoPosControls(false);
        }
        #region AeroTech
        private void EnableAutoPosControls(bool enable)
        {
            grpBox_AutoPosition.Enabled = enable;
        }
        private void EnableCameraControls(bool enable)
        {
            grpBox_Cam.Enabled = enable;
        }
        private void EnableAxisContols(bool enable)
        {
            grpBox_StrReczne.Enabled = enable;
            grpBox_Axis.Enabled = enable;
            grpBox_Error.Enabled = enable;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.Disconnect();
            DestroyCamera();
        }
        private void SetTaskState(NewTaskStatesArrivedEventArgs e)
        {
            lbl_State.Text = e.TaskStates[this.taskIndex].ToString();
        }
        private void SetAxisState(NewDiagPacketArrivedEventArgs e)
        {
            lbl_Enabled.Text = e.Data[this.axisIndex].DriveStatus.Enabled.ToString();
            lbl_Speed.Text = e.Data[this.axisIndex].AxisStatus.Homed.ToString();
            lbl_Fault.Text = (!e.Data[this.axisIndex].AxisFault.None).ToString();
            lbl_Position.Text = e.Data[this.axisIndex].PositionFeedback.ToString();
            lbl_Speed.Text = e.Data[this.axisIndex].VelocityFeedback.ToString();
        }

        private void bt_SerwCon_Click(object sender, EventArgs e)
        {
            try
            {
                this.myController = Controller.Connect();
                chkBox_Serw.Checked = true;
                EnableAxisContols(true);
                if (chkBox_Serw.Checked == true && chkBox_Cam.Checked == true)
                {
                    EnableAutoPosControls(true);
                }
                
                foreach (AxisInfo axis in this.myController.Information.Axes)
                {
                    cmbBox_AxisSelect.Items.Add(axis.Name);
                }
                this.axisIndex = 0;
                cmbBox_AxisSelect.SelectedIndex = this.axisIndex;

                foreach (Aerotech.A3200.Tasks.Task task in this.myController.Tasks)
                {
                    if (task.State != TaskState.Inactive)
                    {
                        cmbBox_TaskID.Items.Add(task.Name.ToString());
                    }
                }

                this.taskIndex = 1;
                cmbBox_TaskID.SelectedIndex = this.taskIndex - 1;

                this.myController.ControlCenter.TaskStates.NewTaskStatesArrived += new EventHandler<NewTaskStatesArrivedEventArgs>(TaskStates_NewTasklStatesArrived);
                this.myController.ControlCenter.Diagnostics.NewDiagPacketArrived += new EventHandler<NewDiagPacketArrivedEventArgs>(Diagnosrics_NewDiagPacketArrived);
            }
            catch(A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void Diagnosrics_NewDiagPacketArrived(object sender, NewDiagPacketArrivedEventArgs e)
        {
            try
            {
                this.Invoke(new Action<NewDiagPacketArrivedEventArgs>(SetAxisState), e);
            }
            catch
            {
            }
        }

        private void TaskStates_NewTasklStatesArrived(object sender, NewTaskStatesArrivedEventArgs e)
        {
            try
            {
                this.Invoke(new Action<NewTaskStatesArrivedEventArgs>(SetTaskState), e);
            }
            catch
            {
            }
        }

        private void bt_SerwDisCon_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.Disconnect();
                chkBox_Serw.Checked = false;
                EnableAxisContols(false);
                EnableAutoPosControls(false);
                
            }
            catch (Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void bt_AxisEnable_Click(object sender, EventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Axes[this.axisIndex].Motion.Enable();
                
            }
            catch(A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void bt_AxisDisable_Click(object sender, EventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Axes[this.axisIndex].Motion.Disable();
                
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void cmbBox_AxisSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.axisIndex= cmbBox_AxisSelect.SelectedIndex;
        }

        private void cmbBox_TaskID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.taskIndex= cmbBox_TaskID.SelectedIndex;
        }

        private void bt_AxisProgramStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.myController.Tasks[this.taskIndex].Program.Stop();
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void bt_CW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, double.Parse(tb_Speed.Text));
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void bt_CW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, 0);
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void bt_CCW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, -double.Parse(tb_Speed.Text));
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void bt_CCW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, 0);
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMessage.Text = exception.Message;
            }
        }

        private void bt_ErrorClear_Click(object sender, EventArgs e)
        {
            lbl_ErrorMessage.Text = "";
        }
        private void UpdateSerwConButtons(bool canSerwCon, bool canSerwDisCon)
        {
            bt_SerwCon.Enabled = canSerwCon;
            bt_SerwDisCon.Enabled = canSerwDisCon;
        }
        private void UpdateSerwButtons(bool canEnable, bool canDisEnable)
        {
            bt_AxisEnable.Enabled = canEnable;
            bt_AxisDisable.Enabled = canDisEnable;
            bt_CCW.Enabled = !canEnable;
            bt_CW.Enabled = !canEnable;

        }
        #endregion AeroTech
        //--------------------------------------------------------------------------------------------
        #region Kamera
        private void bt_CamCon_Click(object sender, EventArgs e)
        {
            Connect();
            chkBox_Cam.Checked = true;
            EnableCameraControls(true);
            UpdateCameraConButtons(false, true);
            UpdateCameraButtons(true, false);
            if (chkBox_Serw.Checked == true && chkBox_Cam.Checked == true)
            {
                EnableAutoPosControls(true);
            }
        }

        private void bt_CamDisCon_Click(object sender, EventArgs e)
        {
            chkBox_Cam.Checked = false;
            EnableCameraControls(false);
            EnableAutoPosControls(false);
            UpdateCameraButtons(false, false);
            UpdateCameraConButtons(true, false);
        }

        private void ContinousShot()
        {
            try
            {
                Configuration.AcquireContinuous(camera, null);
                camera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            catch(Exception exception)
            {
                ShowException(exception);
            }
        }

        private void ShowException(Exception exception)
        {
            MessageBox.Show("Błąd: \n" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OneShot()
        {
            try
            {
                Configuration.AcquireSingleFrame(camera, null);
                camera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            catch(Exception exception)
            {
                ShowException(exception);
            }
        }

        private void Stop()
        {
            try
            {
                camera.StreamGrabber.Stop();
            }
            catch(Exception exception)
            {
                ShowException(exception);
            }
        }

        private void DestroyCamera()
        {
            try
            {
                if(camera != null)
                {
                    camera.Close();
                    camera.Dispose();
                    camera= null;
                }
            }
            catch(Exception exception)
            {
                ShowException(exception);
            }
        }

        private void Connect()
        {
            try
            {
                camera= new Camera();

                camera.CameraOpened += Configuration.AcquireContinuous;

                camera.ConnectionLost += OnConnectionLost;
                camera.CameraOpened += OnCameraOpened;
                camera.CameraClosed += OnCameraClosed;
                camera.StreamGrabber.GrabStarted += OnGrabStarted;
                camera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                camera.StreamGrabber.GrabStopped += OnGrabStopped;

                camera.Open();
                camera.Parameters[PLCamera.Width].SetValue(600);
                camera.Parameters[PLCamera.Height].SetValue(600);
                camera.Parameters[PLCamera.CenterX].SetValue(true);
                camera.Parameters[PLCamera.CenterY].SetValue(true);
            }
            catch(Exception exception) 
            { 
                ShowException(exception);
            }
        }

        private void OnConnectionLost(object sender, EventArgs e)
        {
            if(InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnConnectionLost), sender, e);
                return;
            }
            DestroyCamera();
        }

        private void OnCameraOpened(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnCameraOpened), sender, e);
                return;
            }
        }

        private void OnCameraClosed(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnCameraClosed), sender, e);
                return;
            }
        }

        private void OnGrabStarted(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnGrabStarted), sender, e);
                return;
            }
        }

        private void OnImageGrabbed(object sender, ImageGrabbedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<ImageGrabbedEventArgs>(OnImageGrabbed),sender, e.Clone());
                return;
            }
            try
            {
                IGrabResult grabResult = e.GrabResult;

                if (grabResult.IsValid)
                {
                    if(!stopWatch.IsRunning || stopWatch.ElapsedMilliseconds > 33)
                    {
                        stopWatch.Restart();

                        Bitmap bitmap = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
                        BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                        converter.OutputPixelFormat = PixelType.BGRA8packed;
                        IntPtr ptrBmp = bmpData.Scan0;
                        converter.Convert(ptrBmp, bmpData.Stride * bitmap.Height, grabResult);
                        bitmap.UnlockBits(bmpData);

                        Bitmap bitmapOld = picBox_Output.Image as Bitmap;
                        picBox_Output.Image = bitmap;
                        if (bitmapOld != null)
                        {
                            bitmapOld.Dispose();
                        }
                    }
                }
            }
            catch(Exception exception)
            {
                ShowException(exception);
            }
            finally
            {
                e.DisposeGrabResultIfClone();
            }

        }

        private void OnGrabStopped(object sender, GrabStopEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<GrabStopEventArgs>(OnGrabStopped), sender, e);
                return;
            }

            stopWatch.Reset();

            if(e.Reason != GrabStopReason.UserRequest)
            {
                MessageBox.Show("Błąd podczas pobierania klatek z kamery: \n" + e.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_StartConShot_Click(object sender, EventArgs e)
        {
            ContinousShot();
            UpdateCameraButtons(false, true);
        }

        private void bt_StopConShot_Click(object sender, EventArgs e)
        {
            Stop();
            UpdateCameraButtons(true, false);
        }

        private void bt_OneShot_Click(object sender, EventArgs e)
        {
            OneShot();
        }

        private void bt_SaveObraz_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bmp files(*.Bmp)|*.Bmp";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.picBox_Output.Image.Save(sfd.FileName, ImageFormat.Bmp);
            }
        }

        private void UpdateCameraButtons(bool canGrab, bool canStop)
        {
            bt_StartConShot.Enabled = canGrab;
            bt_StopConShot.Enabled = canStop;
            bt_SaveObraz.Enabled = canGrab && IsSingleShotSupported();
            bt_OneShot.Enabled = canGrab && IsSingleShotSupported();
        }

        private bool IsSingleShotSupported()
        {
            if (camera == null)
            {
                return false;
            }

            if (!camera.IsOpen)
            {
                return false;
            }

            bool canSet = camera.Parameters[PLCamera.AcquisitionMode].CanSetValue("SingleFrame");
            return canSet;
        }
        private void UpdateCameraConButtons(bool canCon, bool canDisCon)
        {
            bt_CamCon.Enabled = canCon;
            bt_CamDisCon.Enabled = canDisCon;
        }
        #endregion Kamera
        //=================================================================
        #region Pozycjonowanie
        private void TemplateMatching()
        {
            try
            {
                if (picBox_Output.Image == null)
                {
                   return;
                }
                try
                {
                    Bitmap srcBitmap = new Bitmap(picBox_Output.Image);
                    Image<Gray, byte> imgSrc = srcBitmap.ToImage<Gray, byte>();
                    //"kostkatest2.png"
                    //"monotestKostka.jpg"
                    string template = "kostkatest21.bmp";
                    Mat MatTemplate = CvInvoke.Imread(template);
                    Image<Gray, byte> imgTemplate = MatTemplate.Clone().ToImage<Gray, byte>();
                    Mat dst = new Mat();
                    Mat mask = new Mat();
                    CvInvoke.MatchTemplate(imgSrc, imgTemplate, dst, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed, mask);
                    double minVal = 0.0;
                    double maxVal = 0.0;
                    Point minLoc = new Point();
                    Point maxLoc = new Point();
                    double MinMatchQuality = 0.5;
                    CvInvoke.MinMaxLoc(dst, ref minVal, ref maxVal, ref minLoc, ref maxLoc, mask);
                    if (maxVal > MinMatchQuality)
                    {
                        Rectangle r = new Rectangle(maxLoc, imgTemplate.Size);
                        CvInvoke.Rectangle(imgSrc, r, new MCvScalar(0, 0, 255), 5);
                        picBox_Output.Image = imgSrc.ToBitmap();
                        lbl_TempMatchWynik.Text = "Odnaleziono";
                        wyjscie = 1;

                    }
                    else
                    {
                        lbl_TempMatchWynik.Text = "Brak";
                        picBox_Output.Image = imgSrc.ToBitmap();
                        wyjscie = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Pozycjonowanie3()
        {
            try
            {
                this.myController.Commands[TaskId.T01].Axes["X"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["Y"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["Z"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["X"].Motion.Home();
                this.myController.Commands[TaskId.T01].Axes["Y"].Motion.Home();
                this.myController.Commands[TaskId.T01].Axes["Z"].Motion.Home();
                this.myController.Commands.Motion.Linear("X", -38, 15);
                this.myController.Commands.Motion.Linear("Y", -38, 15);
                for (int pozy = 0; pozy < 9; pozy++)
                {
                    for (int pozx = 0; pozx < 8; pozx++)
                    {
                        OneShot();
                        Refresh();
                        TemplateMatching();
                        if (wyjscie == 1)
                        {
                            break;
                        }
                        else
                        {
                            this.myController.Commands.Motion.Linear("X", wart, 15);
                        }
                    }
                    if (pozy == 8 || wyjscie == 1)
                    {
                        break;
                    }
                    else
                    {
                        this.myController.Commands.Motion.Linear("Y", 10, 15);
                        wart = -1 * wart;
                    }

                }
            }
            catch (A3200Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Pozycjonowanie2()
        {
            try
            {
                this.myController.Commands[TaskId.T01].Axes["X"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["Y"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["X"].Motion.Home();
                this.myController.Commands[TaskId.T01].Axes["Y"].Motion.Home();
                this.myController.Commands.Motion.Linear("X", -38, 15);
                this.myController.Commands.Motion.Linear("Y", -38, 15);
                for (int pozy = 0; pozy < 9; pozy++)
                {
                    for (int pozx = 0; pozx < 8; pozx++)
                    {
                        this.myController.Commands.Motion.Linear("X", wart, 15);
                        if (pozy == 4 && pozx == 3)
                        {
                            OneShot();
                            TemplateMatching();
                            if (wyjscie == 1)
                            {
                                break;
                            }
                        }
                    }
                    if (pozy == 8 || wyjscie == 1)
                    {
                        break;
                    }
                    else
                    {
                        this.myController.Commands.Motion.Linear("Y", 10, 15);
                        wart = -1 * wart;
                    }

                }
            }
            catch (A3200Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion Pozycjonowanie

        private void bt_TempWykryj_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_AutoPositionStart_Click(object sender, EventArgs e)
        {
            Pozycjonowanie2();
        }
    }
}
