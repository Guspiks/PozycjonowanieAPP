namespace PozycjonowanieFinal
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_CamCon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBox_Cam = new System.Windows.Forms.CheckBox();
            this.bt_SerwCon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBox_Serw = new System.Windows.Forms.CheckBox();
            this.grpBox_StrReczne = new System.Windows.Forms.GroupBox();
            this.grpBox_Error = new System.Windows.Forms.GroupBox();
            this.bt_ErrorClear = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.cmbBox_TaskID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_AxisProgramStop = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grpBox_Axis = new System.Windows.Forms.GroupBox();
            this.lbl_Fault = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_Homed = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_Enabled = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_CCW = new System.Windows.Forms.Button();
            this.bt_CW = new System.Windows.Forms.Button();
            this.tb_Speed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_AxisDisable = new System.Windows.Forms.Button();
            this.bt_AxisEnable = new System.Windows.Forms.Button();
            this.cmbBox_AxisSelect = new System.Windows.Forms.ComboBox();
            this.grpBox_Cam = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_OneShot = new System.Windows.Forms.Button();
            this.bt_StopConShot = new System.Windows.Forms.Button();
            this.bt_StartConShot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_SaveObraz = new System.Windows.Forms.Button();
            this.picBox_Output = new System.Windows.Forms.PictureBox();
            this.bt_SerwDisCon = new System.Windows.Forms.Button();
            this.bt_CamDisCon = new System.Windows.Forms.Button();
            this.grpBox_AutoPosition = new System.Windows.Forms.GroupBox();
            this.lbl_TempMatchWynik = new System.Windows.Forms.Label();
            this.bt_AutoPositionStart = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.grpBox_StrReczne.SuspendLayout();
            this.grpBox_Error.SuspendLayout();
            this.grpBox_Axis.SuspendLayout();
            this.grpBox_Cam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Output)).BeginInit();
            this.grpBox_AutoPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_CamCon
            // 
            this.bt_CamCon.Location = new System.Drawing.Point(412, 31);
            this.bt_CamCon.Name = "bt_CamCon";
            this.bt_CamCon.Size = new System.Drawing.Size(75, 23);
            this.bt_CamCon.TabIndex = 0;
            this.bt_CamCon.Text = "Connect";
            this.bt_CamCon.UseVisualStyleBackColor = true;
            this.bt_CamCon.Click += new System.EventHandler(this.bt_CamCon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kamera";
            // 
            // chkBox_Cam
            // 
            this.chkBox_Cam.AutoCheck = false;
            this.chkBox_Cam.AutoSize = true;
            this.chkBox_Cam.Location = new System.Drawing.Point(449, 8);
            this.chkBox_Cam.Name = "chkBox_Cam";
            this.chkBox_Cam.Size = new System.Drawing.Size(67, 17);
            this.chkBox_Cam.TabIndex = 2;
            this.chkBox_Cam.Text = "Aktywna";
            this.chkBox_Cam.UseVisualStyleBackColor = true;
            // 
            // bt_SerwCon
            // 
            this.bt_SerwCon.Location = new System.Drawing.Point(25, 31);
            this.bt_SerwCon.Name = "bt_SerwCon";
            this.bt_SerwCon.Size = new System.Drawing.Size(75, 23);
            this.bt_SerwCon.TabIndex = 3;
            this.bt_SerwCon.Text = "Connect";
            this.bt_SerwCon.UseVisualStyleBackColor = true;
            this.bt_SerwCon.Click += new System.EventHandler(this.bt_SerwCon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Silniki";
            // 
            // chkBox_Serw
            // 
            this.chkBox_Serw.AutoCheck = false;
            this.chkBox_Serw.AutoSize = true;
            this.chkBox_Serw.Location = new System.Drawing.Point(52, 8);
            this.chkBox_Serw.Name = "chkBox_Serw";
            this.chkBox_Serw.Size = new System.Drawing.Size(67, 17);
            this.chkBox_Serw.TabIndex = 5;
            this.chkBox_Serw.Text = "Aktywne";
            this.chkBox_Serw.UseVisualStyleBackColor = true;
            this.chkBox_Serw.CheckedChanged += new System.EventHandler(this.chkBox_Serw_CheckedChanged);
            // 
            // grpBox_StrReczne
            // 
            this.grpBox_StrReczne.Controls.Add(this.grpBox_Error);
            this.grpBox_StrReczne.Controls.Add(this.grpBox_Axis);
            this.grpBox_StrReczne.Location = new System.Drawing.Point(12, 60);
            this.grpBox_StrReczne.Name = "grpBox_StrReczne";
            this.grpBox_StrReczne.Size = new System.Drawing.Size(385, 703);
            this.grpBox_StrReczne.TabIndex = 6;
            this.grpBox_StrReczne.TabStop = false;
            this.grpBox_StrReczne.Text = "Sterowanie Ręczne Silnikami";
            // 
            // grpBox_Error
            // 
            this.grpBox_Error.Controls.Add(this.bt_ErrorClear);
            this.grpBox_Error.Controls.Add(this.label19);
            this.grpBox_Error.Controls.Add(this.lbl_ErrorMessage);
            this.grpBox_Error.Controls.Add(this.label14);
            this.grpBox_Error.Controls.Add(this.label16);
            this.grpBox_Error.Controls.Add(this.lbl_State);
            this.grpBox_Error.Controls.Add(this.cmbBox_TaskID);
            this.grpBox_Error.Controls.Add(this.label12);
            this.grpBox_Error.Controls.Add(this.bt_AxisProgramStop);
            this.grpBox_Error.Controls.Add(this.label10);
            this.grpBox_Error.Location = new System.Drawing.Point(6, 340);
            this.grpBox_Error.Name = "grpBox_Error";
            this.grpBox_Error.Size = new System.Drawing.Size(372, 356);
            this.grpBox_Error.TabIndex = 1;
            this.grpBox_Error.TabStop = false;
            this.grpBox_Error.Text = "Błędy";
            // 
            // bt_ErrorClear
            // 
            this.bt_ErrorClear.Location = new System.Drawing.Point(13, 327);
            this.bt_ErrorClear.Name = "bt_ErrorClear";
            this.bt_ErrorClear.Size = new System.Drawing.Size(75, 23);
            this.bt_ErrorClear.TabIndex = 24;
            this.bt_ErrorClear.Text = "Wyczyść";
            this.bt_ErrorClear.UseVisualStyleBackColor = true;
            this.bt_ErrorClear.Click += new System.EventHandler(this.bt_ErrorClear_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 311);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Wyczyść komunikat o błędzie";
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(6, 171);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(360, 134);
            this.lbl_ErrorMessage.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Komunikat o błędzie";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Stan osi";
            // 
            // lbl_State
            // 
            this.lbl_State.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_State.Location = new System.Drawing.Point(6, 84);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(360, 70);
            this.lbl_State.TabIndex = 19;
            // 
            // cmbBox_TaskID
            // 
            this.cmbBox_TaskID.FormattingEnabled = true;
            this.cmbBox_TaskID.Location = new System.Drawing.Point(215, 38);
            this.cmbBox_TaskID.Name = "cmbBox_TaskID";
            this.cmbBox_TaskID.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_TaskID.TabIndex = 3;
            this.cmbBox_TaskID.SelectedIndexChanged += new System.EventHandler(this.cmbBox_TaskID_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Zadanie(Task)";
            // 
            // bt_AxisProgramStop
            // 
            this.bt_AxisProgramStop.Location = new System.Drawing.Point(13, 37);
            this.bt_AxisProgramStop.Name = "bt_AxisProgramStop";
            this.bt_AxisProgramStop.Size = new System.Drawing.Size(75, 23);
            this.bt_AxisProgramStop.TabIndex = 1;
            this.bt_AxisProgramStop.Text = "Stop";
            this.bt_AxisProgramStop.UseVisualStyleBackColor = true;
            this.bt_AxisProgramStop.Click += new System.EventHandler(this.bt_AxisProgramStop_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Zatrzymaj aktualny program osi";
            // 
            // grpBox_Axis
            // 
            this.grpBox_Axis.Controls.Add(this.lbl_Fault);
            this.grpBox_Axis.Controls.Add(this.label17);
            this.grpBox_Axis.Controls.Add(this.lbl_Homed);
            this.grpBox_Axis.Controls.Add(this.label15);
            this.grpBox_Axis.Controls.Add(this.lbl_Enabled);
            this.grpBox_Axis.Controls.Add(this.label13);
            this.grpBox_Axis.Controls.Add(this.lbl_Speed);
            this.grpBox_Axis.Controls.Add(this.label11);
            this.grpBox_Axis.Controls.Add(this.lbl_Position);
            this.grpBox_Axis.Controls.Add(this.label9);
            this.grpBox_Axis.Controls.Add(this.label8);
            this.grpBox_Axis.Controls.Add(this.bt_CCW);
            this.grpBox_Axis.Controls.Add(this.bt_CW);
            this.grpBox_Axis.Controls.Add(this.tb_Speed);
            this.grpBox_Axis.Controls.Add(this.label7);
            this.grpBox_Axis.Controls.Add(this.label6);
            this.grpBox_Axis.Controls.Add(this.bt_AxisDisable);
            this.grpBox_Axis.Controls.Add(this.bt_AxisEnable);
            this.grpBox_Axis.Controls.Add(this.cmbBox_AxisSelect);
            this.grpBox_Axis.Location = new System.Drawing.Point(6, 19);
            this.grpBox_Axis.Name = "grpBox_Axis";
            this.grpBox_Axis.Size = new System.Drawing.Size(372, 315);
            this.grpBox_Axis.TabIndex = 0;
            this.grpBox_Axis.TabStop = false;
            this.grpBox_Axis.Text = "Osie";
            // 
            // lbl_Fault
            // 
            this.lbl_Fault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Fault.Location = new System.Drawing.Point(84, 276);
            this.lbl_Fault.Name = "lbl_Fault";
            this.lbl_Fault.Size = new System.Drawing.Size(54, 17);
            this.lbl_Fault.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Fault";
            // 
            // lbl_Homed
            // 
            this.lbl_Homed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Homed.Location = new System.Drawing.Point(84, 251);
            this.lbl_Homed.Name = "lbl_Homed";
            this.lbl_Homed.Size = new System.Drawing.Size(54, 17);
            this.lbl_Homed.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Homed";
            // 
            // lbl_Enabled
            // 
            this.lbl_Enabled.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Enabled.Location = new System.Drawing.Point(84, 226);
            this.lbl_Enabled.Name = "lbl_Enabled";
            this.lbl_Enabled.Size = new System.Drawing.Size(54, 17);
            this.lbl_Enabled.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Enabled";
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Speed.Location = new System.Drawing.Point(84, 201);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(54, 17);
            this.lbl_Speed.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Prędkość";
            // 
            // lbl_Position
            // 
            this.lbl_Position.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Position.Location = new System.Drawing.Point(84, 176);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(54, 17);
            this.lbl_Position.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pozycja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stan osi";
            // 
            // bt_CCW
            // 
            this.bt_CCW.Location = new System.Drawing.Point(107, 106);
            this.bt_CCW.Name = "bt_CCW";
            this.bt_CCW.Size = new System.Drawing.Size(56, 23);
            this.bt_CCW.TabIndex = 7;
            this.bt_CCW.Text = "CCW";
            this.bt_CCW.UseVisualStyleBackColor = true;
            this.bt_CCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_CCW_MouseDown);
            this.bt_CCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_CCW_MouseUp);
            // 
            // bt_CW
            // 
            this.bt_CW.Location = new System.Drawing.Point(34, 106);
            this.bt_CW.Name = "bt_CW";
            this.bt_CW.Size = new System.Drawing.Size(56, 23);
            this.bt_CW.TabIndex = 6;
            this.bt_CW.Text = "CW";
            this.bt_CW.UseVisualStyleBackColor = true;
            this.bt_CW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_CW_MouseDown);
            this.bt_CW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_CW_MouseUp);
            // 
            // tb_Speed
            // 
            this.tb_Speed.Location = new System.Drawing.Point(89, 74);
            this.tb_Speed.Name = "tb_Speed";
            this.tb_Speed.Size = new System.Drawing.Size(74, 20);
            this.tb_Speed.TabIndex = 5;
            this.tb_Speed.Text = "10";
            this.tb_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Prędkość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Freerun";
            // 
            // bt_AxisDisable
            // 
            this.bt_AxisDisable.Location = new System.Drawing.Point(188, 19);
            this.bt_AxisDisable.Name = "bt_AxisDisable";
            this.bt_AxisDisable.Size = new System.Drawing.Size(75, 23);
            this.bt_AxisDisable.TabIndex = 2;
            this.bt_AxisDisable.Text = "Disable";
            this.bt_AxisDisable.UseVisualStyleBackColor = true;
            this.bt_AxisDisable.Click += new System.EventHandler(this.bt_AxisDisable_Click);
            // 
            // bt_AxisEnable
            // 
            this.bt_AxisEnable.Location = new System.Drawing.Point(107, 19);
            this.bt_AxisEnable.Name = "bt_AxisEnable";
            this.bt_AxisEnable.Size = new System.Drawing.Size(75, 23);
            this.bt_AxisEnable.TabIndex = 1;
            this.bt_AxisEnable.Text = "Enable";
            this.bt_AxisEnable.UseVisualStyleBackColor = true;
            this.bt_AxisEnable.Click += new System.EventHandler(this.bt_AxisEnable_Click);
            // 
            // cmbBox_AxisSelect
            // 
            this.cmbBox_AxisSelect.FormattingEnabled = true;
            this.cmbBox_AxisSelect.Location = new System.Drawing.Point(7, 20);
            this.cmbBox_AxisSelect.Name = "cmbBox_AxisSelect";
            this.cmbBox_AxisSelect.Size = new System.Drawing.Size(94, 21);
            this.cmbBox_AxisSelect.TabIndex = 0;
            this.cmbBox_AxisSelect.SelectedIndexChanged += new System.EventHandler(this.cmbBox_AxisSelect_SelectedIndexChanged);
            // 
            // grpBox_Cam
            // 
            this.grpBox_Cam.Controls.Add(this.label5);
            this.grpBox_Cam.Controls.Add(this.bt_OneShot);
            this.grpBox_Cam.Controls.Add(this.bt_StopConShot);
            this.grpBox_Cam.Controls.Add(this.bt_StartConShot);
            this.grpBox_Cam.Controls.Add(this.label4);
            this.grpBox_Cam.Controls.Add(this.label3);
            this.grpBox_Cam.Controls.Add(this.bt_SaveObraz);
            this.grpBox_Cam.Controls.Add(this.picBox_Output);
            this.grpBox_Cam.Location = new System.Drawing.Point(403, 60);
            this.grpBox_Cam.Name = "grpBox_Cam";
            this.grpBox_Cam.Size = new System.Drawing.Size(612, 703);
            this.grpBox_Cam.TabIndex = 7;
            this.grpBox_Cam.TabStop = false;
            this.grpBox_Cam.Text = "Kamera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pojedyńcza klatka";
            // 
            // bt_OneShot
            // 
            this.bt_OneShot.Location = new System.Drawing.Point(212, 37);
            this.bt_OneShot.Name = "bt_OneShot";
            this.bt_OneShot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_OneShot.Size = new System.Drawing.Size(146, 23);
            this.bt_OneShot.TabIndex = 6;
            this.bt_OneShot.Text = "Zdjęcie";
            this.bt_OneShot.UseVisualStyleBackColor = true;
            this.bt_OneShot.Click += new System.EventHandler(this.bt_OneShot_Click);
            // 
            // bt_StopConShot
            // 
            this.bt_StopConShot.Location = new System.Drawing.Point(9, 67);
            this.bt_StopConShot.Name = "bt_StopConShot";
            this.bt_StopConShot.Size = new System.Drawing.Size(146, 23);
            this.bt_StopConShot.TabIndex = 5;
            this.bt_StopConShot.Text = "Stop";
            this.bt_StopConShot.UseVisualStyleBackColor = true;
            this.bt_StopConShot.Click += new System.EventHandler(this.bt_StopConShot_Click);
            // 
            // bt_StartConShot
            // 
            this.bt_StartConShot.Location = new System.Drawing.Point(9, 37);
            this.bt_StartConShot.Name = "bt_StartConShot";
            this.bt_StartConShot.Size = new System.Drawing.Size(146, 23);
            this.bt_StartConShot.TabIndex = 4;
            this.bt_StartConShot.Text = "Start";
            this.bt_StartConShot.UseVisualStyleBackColor = true;
            this.bt_StartConShot.Click += new System.EventHandler(this.bt_StartConShot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wideo z kamery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zapisz zdjęcie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_SaveObraz
            // 
            this.bt_SaveObraz.Location = new System.Drawing.Point(403, 37);
            this.bt_SaveObraz.Name = "bt_SaveObraz";
            this.bt_SaveObraz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_SaveObraz.Size = new System.Drawing.Size(146, 23);
            this.bt_SaveObraz.TabIndex = 1;
            this.bt_SaveObraz.Text = "Zapisz";
            this.bt_SaveObraz.UseVisualStyleBackColor = true;
            this.bt_SaveObraz.Click += new System.EventHandler(this.bt_SaveObraz_Click);
            // 
            // picBox_Output
            // 
            this.picBox_Output.Location = new System.Drawing.Point(6, 96);
            this.picBox_Output.Name = "picBox_Output";
            this.picBox_Output.Size = new System.Drawing.Size(600, 600);
            this.picBox_Output.TabIndex = 0;
            this.picBox_Output.TabStop = false;
            // 
            // bt_SerwDisCon
            // 
            this.bt_SerwDisCon.Location = new System.Drawing.Point(106, 31);
            this.bt_SerwDisCon.Name = "bt_SerwDisCon";
            this.bt_SerwDisCon.Size = new System.Drawing.Size(75, 23);
            this.bt_SerwDisCon.TabIndex = 8;
            this.bt_SerwDisCon.Text = "Disconnect";
            this.bt_SerwDisCon.UseVisualStyleBackColor = true;
            this.bt_SerwDisCon.Click += new System.EventHandler(this.bt_SerwDisCon_Click);
            // 
            // bt_CamDisCon
            // 
            this.bt_CamDisCon.Location = new System.Drawing.Point(493, 31);
            this.bt_CamDisCon.Name = "bt_CamDisCon";
            this.bt_CamDisCon.Size = new System.Drawing.Size(75, 23);
            this.bt_CamDisCon.TabIndex = 9;
            this.bt_CamDisCon.Text = "Disconnect";
            this.bt_CamDisCon.UseVisualStyleBackColor = true;
            this.bt_CamDisCon.Click += new System.EventHandler(this.bt_CamDisCon_Click);
            // 
            // grpBox_AutoPosition
            // 
            this.grpBox_AutoPosition.Controls.Add(this.lbl_TempMatchWynik);
            this.grpBox_AutoPosition.Controls.Add(this.bt_AutoPositionStart);
            this.grpBox_AutoPosition.Controls.Add(this.label18);
            this.grpBox_AutoPosition.Location = new System.Drawing.Point(12, 769);
            this.grpBox_AutoPosition.Name = "grpBox_AutoPosition";
            this.grpBox_AutoPosition.Size = new System.Drawing.Size(1003, 92);
            this.grpBox_AutoPosition.TabIndex = 10;
            this.grpBox_AutoPosition.TabStop = false;
            this.grpBox_AutoPosition.Text = "Automatyczne pozycjonowanie";
            // 
            // lbl_TempMatchWynik
            // 
            this.lbl_TempMatchWynik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TempMatchWynik.Location = new System.Drawing.Point(438, 20);
            this.lbl_TempMatchWynik.Name = "lbl_TempMatchWynik";
            this.lbl_TempMatchWynik.Size = new System.Drawing.Size(547, 61);
            this.lbl_TempMatchWynik.TabIndex = 2;
            // 
            // bt_AutoPositionStart
            // 
            this.bt_AutoPositionStart.Location = new System.Drawing.Point(51, 58);
            this.bt_AutoPositionStart.Name = "bt_AutoPositionStart";
            this.bt_AutoPositionStart.Size = new System.Drawing.Size(360, 23);
            this.bt_AutoPositionStart.TabIndex = 1;
            this.bt_AutoPositionStart.Text = "Start";
            this.bt_AutoPositionStart.UseVisualStyleBackColor = true;
            this.bt_AutoPositionStart.Click += new System.EventHandler(this.bt_AutoPositionStart_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(49, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(364, 26);
            this.label18.TabIndex = 0;
            this.label18.Text = "Zpozycjonuj stół obrabiarki za pomocą wykrywania znacznika przez kamerę\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 866);
            this.Controls.Add(this.grpBox_AutoPosition);
            this.Controls.Add(this.bt_CamDisCon);
            this.Controls.Add(this.bt_SerwDisCon);
            this.Controls.Add(this.grpBox_Cam);
            this.Controls.Add(this.grpBox_StrReczne);
            this.Controls.Add(this.chkBox_Serw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_SerwCon);
            this.Controls.Add(this.chkBox_Cam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_CamCon);
            this.Name = "Form1";
            this.Text = "LaserSterownik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox_StrReczne.ResumeLayout(false);
            this.grpBox_Error.ResumeLayout(false);
            this.grpBox_Error.PerformLayout();
            this.grpBox_Axis.ResumeLayout(false);
            this.grpBox_Axis.PerformLayout();
            this.grpBox_Cam.ResumeLayout(false);
            this.grpBox_Cam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Output)).EndInit();
            this.grpBox_AutoPosition.ResumeLayout(false);
            this.grpBox_AutoPosition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_CamCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBox_Cam;
        private System.Windows.Forms.Button bt_SerwCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBox_Serw;
        private System.Windows.Forms.GroupBox grpBox_StrReczne;
        private System.Windows.Forms.GroupBox grpBox_Error;
        private System.Windows.Forms.GroupBox grpBox_Axis;
        private System.Windows.Forms.GroupBox grpBox_Cam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_SaveObraz;
        private System.Windows.Forms.PictureBox picBox_Output;
        private System.Windows.Forms.Button bt_ErrorClear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_ErrorMessage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.ComboBox cmbBox_TaskID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_AxisProgramStop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Fault;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_Homed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_Enabled;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_CCW;
        private System.Windows.Forms.Button bt_CW;
        private System.Windows.Forms.TextBox tb_Speed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_AxisDisable;
        private System.Windows.Forms.Button bt_AxisEnable;
        private System.Windows.Forms.ComboBox cmbBox_AxisSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_OneShot;
        private System.Windows.Forms.Button bt_StopConShot;
        private System.Windows.Forms.Button bt_StartConShot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_SerwDisCon;
        private System.Windows.Forms.Button bt_CamDisCon;
        private System.Windows.Forms.GroupBox grpBox_AutoPosition;
        private System.Windows.Forms.Button bt_AutoPositionStart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_TempMatchWynik;
    }
}

