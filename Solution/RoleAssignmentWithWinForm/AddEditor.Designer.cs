
namespace RoleAssignmentWithWinForm
{
    partial class AddEditor
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
            this.labelEditorType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.checkBoxRead = new System.Windows.Forms.CheckBox();
            this.checkBoxCreate = new System.Windows.Forms.CheckBox();
            this.txtEditorEmail = new System.Windows.Forms.TextBox();
            this.txtEditorPassword = new System.Windows.Forms.TextBox();
            this.txtEditorName = new System.Windows.Forms.TextBox();
            this.labelEditorPassword = new System.Windows.Forms.Label();
            this.labelEditorEmail = new System.Windows.Forms.Label();
            this.labelEditorName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEditorType
            // 
            this.labelEditorType.AutoSize = true;
            this.labelEditorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditorType.Location = new System.Drawing.Point(96, 251);
            this.labelEditorType.Name = "labelEditorType";
            this.labelEditorType.Size = new System.Drawing.Size(102, 24);
            this.labelEditorType.TabIndex = 25;
            this.labelEditorType.Text = "User Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "admin",
            "editor"});
            this.comboBoxType.Location = new System.Drawing.Point(274, 247);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(167, 28);
            this.comboBoxType.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(607, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelete.Location = new System.Drawing.Point(374, 385);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(75, 24);
            this.checkBoxDelete.TabIndex = 8;
            this.checkBoxDelete.Text = "Delete";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUpdate.Location = new System.Drawing.Point(234, 385);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(81, 24);
            this.checkBoxUpdate.TabIndex = 7;
            this.checkBoxUpdate.Text = "Update";
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxRead
            // 
            this.checkBoxRead.AutoSize = true;
            this.checkBoxRead.Checked = true;
            this.checkBoxRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRead.Location = new System.Drawing.Point(374, 331);
            this.checkBoxRead.Name = "checkBoxRead";
            this.checkBoxRead.Size = new System.Drawing.Size(67, 24);
            this.checkBoxRead.TabIndex = 6;
            this.checkBoxRead.Text = "Read";
            this.checkBoxRead.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreate
            // 
            this.checkBoxCreate.AutoSize = true;
            this.checkBoxCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCreate.Location = new System.Drawing.Point(234, 331);
            this.checkBoxCreate.Name = "checkBoxCreate";
            this.checkBoxCreate.Size = new System.Drawing.Size(76, 24);
            this.checkBoxCreate.TabIndex = 5;
            this.checkBoxCreate.Text = "Create";
            this.checkBoxCreate.UseVisualStyleBackColor = true;
            // 
            // txtEditorEmail
            // 
            this.txtEditorEmail.Location = new System.Drawing.Point(274, 109);
            this.txtEditorEmail.Name = "txtEditorEmail";
            this.txtEditorEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEditorEmail.TabIndex = 2;
            // 
            // txtEditorPassword
            // 
            this.txtEditorPassword.Location = new System.Drawing.Point(274, 177);
            this.txtEditorPassword.Name = "txtEditorPassword";
            this.txtEditorPassword.Size = new System.Drawing.Size(167, 20);
            this.txtEditorPassword.TabIndex = 3;
            // 
            // txtEditorName
            // 
            this.txtEditorName.Location = new System.Drawing.Point(274, 48);
            this.txtEditorName.Name = "txtEditorName";
            this.txtEditorName.Size = new System.Drawing.Size(167, 20);
            this.txtEditorName.TabIndex = 1;
            // 
            // labelEditorPassword
            // 
            this.labelEditorPassword.AutoSize = true;
            this.labelEditorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditorPassword.Location = new System.Drawing.Point(96, 173);
            this.labelEditorPassword.Name = "labelEditorPassword";
            this.labelEditorPassword.Size = new System.Drawing.Size(97, 24);
            this.labelEditorPassword.TabIndex = 15;
            this.labelEditorPassword.Text = "Password:";
            // 
            // labelEditorEmail
            // 
            this.labelEditorEmail.AutoSize = true;
            this.labelEditorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditorEmail.Location = new System.Drawing.Point(96, 109);
            this.labelEditorEmail.Name = "labelEditorEmail";
            this.labelEditorEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEditorEmail.TabIndex = 14;
            this.labelEditorEmail.Text = "Email:";
            // 
            // labelEditorName
            // 
            this.labelEditorName.AutoSize = true;
            this.labelEditorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditorName.Location = new System.Drawing.Point(96, 45);
            this.labelEditorName.Name = "labelEditorName";
            this.labelEditorName.Size = new System.Drawing.Size(102, 24);
            this.labelEditorName.TabIndex = 13;
            this.labelEditorName.Text = "Username:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(607, 141);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelEditorType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.checkBoxUpdate);
            this.Controls.Add(this.checkBoxRead);
            this.Controls.Add(this.checkBoxCreate);
            this.Controls.Add(this.txtEditorEmail);
            this.Controls.Add(this.txtEditorPassword);
            this.Controls.Add(this.txtEditorName);
            this.Controls.Add(this.labelEditorPassword);
            this.Controls.Add(this.labelEditorEmail);
            this.Controls.Add(this.labelEditorName);
            this.Name = "AddEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditorType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxUpdate;
        private System.Windows.Forms.CheckBox checkBoxRead;
        private System.Windows.Forms.CheckBox checkBoxCreate;
        private System.Windows.Forms.TextBox txtEditorEmail;
        private System.Windows.Forms.TextBox txtEditorPassword;
        private System.Windows.Forms.TextBox txtEditorName;
        private System.Windows.Forms.Label labelEditorPassword;
        private System.Windows.Forms.Label labelEditorEmail;
        private System.Windows.Forms.Label labelEditorName;
        private System.Windows.Forms.Button btnBack;
    }
}