namespace AntrianFM
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.fmUserDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkRole = new System.Windows.Forms.CheckBox();
            this.lblUser = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fmUserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(2, 16);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(44, 13);
            userIdLabel.TabIndex = 1;
            userIdLabel.Text = "User Id:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(2, 51);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(60, 13);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "UserName:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(2, 94);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // fmUserDataGridView
            // 
            this.fmUserDataGridView.AutoGenerateColumns = false;
            this.fmUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fmUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.fmUserDataGridView.DataSource = this.fmUserBindingSource;
            this.fmUserDataGridView.Location = new System.Drawing.Point(12, 188);
            this.fmUserDataGridView.Name = "fmUserDataGridView";
            this.fmUserDataGridView.Size = new System.Drawing.Size(418, 220);
            this.fmUserDataGridView.TabIndex = 1;
            this.fmUserDataGridView.DoubleClick += new System.EventHandler(this.fmUserDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // fmUserBindingSource
            // 
            this.fmUserBindingSource.DataSource = typeof(AntrianFM.FmUser);
            // 
            // txtUserId
            // 
            this.txtUserId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmUserBindingSource, "UserId", true));
            this.txtUserId.Location = new System.Drawing.Point(64, 13);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(336, 20);
            this.txtUserId.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmUserBindingSource, "UserName", true));
            this.txtUserName.Location = new System.Drawing.Point(64, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(336, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmUserBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(64, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkRole
            // 
            this.chkRole.AutoSize = true;
            this.chkRole.Location = new System.Drawing.Point(64, 117);
            this.chkRole.Name = "chkRole";
            this.chkRole.Size = new System.Drawing.Size(48, 17);
            this.chkRole.TabIndex = 8;
            this.chkRole.Text = "Role";
            this.chkRole.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(2, 414);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(457, 23);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "label1";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 436);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.chkRole);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.fmUserDataGridView);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fmUserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fmUserBindingSource;
        private System.Windows.Forms.DataGridView fmUserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkRole;
        private System.Windows.Forms.Label lblUser;

    }
}