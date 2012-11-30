﻿using System.Windows.Forms;
namespace GrouponDesktop.Views
 {
    partial class LoginView : DefaultView
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
             this.label1 = new System.Windows.Forms.Label();
             this.label2 = new System.Windows.Forms.Label();
             this.usernameTextBox = new System.Windows.Forms.TextBox();
             this.passwordTextBox = new System.Windows.Forms.TextBox();
             this.loginButton = new System.Windows.Forms.Button();
             this.label3 = new System.Windows.Forms.Label();
             this.registrarButton = new System.Windows.Forms.Button();
             this.SuspendLayout();
             // 
             // label1
             // 
             this.label1.AutoSize = true;
             this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.label1.Location = new System.Drawing.Point(28, 14);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(64, 21);
             this.label1.TabIndex = 0;
             this.label1.Text = "Usuario";
             // 
             // label2
             // 
             this.label2.AutoSize = true;
             this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.label2.Location = new System.Drawing.Point(15, 41);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(77, 21);
             this.label2.TabIndex = 1;
             this.label2.Text = "Password";
             // 
             // usernameTextBox
             // 
             this.usernameTextBox.Location = new System.Drawing.Point(97, 17);
             this.usernameTextBox.Name = "usernameTextBox";
             this.usernameTextBox.Size = new System.Drawing.Size(158, 20);
             this.usernameTextBox.TabIndex = 2;
             // 
             // passwordTextBox
             // 
             this.passwordTextBox.Location = new System.Drawing.Point(97, 44);
             this.passwordTextBox.Name = "passwordTextBox";
             this.passwordTextBox.Size = new System.Drawing.Size(158, 20);
             this.passwordTextBox.TabIndex = 3;
             this.passwordTextBox.UseSystemPasswordChar = true;
             // 
             // loginButton
             // 
             this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.loginButton.Location = new System.Drawing.Point(32, 86);
             this.loginButton.Name = "loginButton";
             this.loginButton.Size = new System.Drawing.Size(223, 38);
             this.loginButton.TabIndex = 4;
             this.loginButton.Text = "Iniciar sesion";
             this.loginButton.UseVisualStyleBackColor = true;
             // 
             // label3
             // 
             this.label3.AutoSize = true;
             this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.label3.Location = new System.Drawing.Point(321, 14);
             this.label3.Name = "label3";
             this.label3.Size = new System.Drawing.Size(169, 50);
             this.label3.TabIndex = 5;
             this.label3.Text = "No tenes usuario?\r\nRegistrate!";
             this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
             // 
             // registrarButton
             // 
             this.registrarButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.registrarButton.Location = new System.Drawing.Point(306, 86);
             this.registrarButton.Name = "registrarButton";
             this.registrarButton.Size = new System.Drawing.Size(184, 38);
             this.registrarButton.TabIndex = 6;
             this.registrarButton.Text = "Registrarse";
             this.registrarButton.UseVisualStyleBackColor = true;
             // 
             // LoginView
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(511, 152);
             this.Controls.Add(this.registrarButton);
             this.Controls.Add(this.label3);
             this.Controls.Add(this.loginButton);
             this.Controls.Add(this.passwordTextBox);
             this.Controls.Add(this.usernameTextBox);
             this.Controls.Add(this.label2);
             this.Controls.Add(this.label1);
             this.Name = "LoginView";
             this.Text = "LoginView";
             this.ResumeLayout(false);
             this.PerformLayout();

         }

         #endregion

         private System.Windows.Forms.Label label1;
         private System.Windows.Forms.Label label2;
         private System.Windows.Forms.TextBox usernameTextBox;
         private System.Windows.Forms.TextBox passwordTextBox;
         private System.Windows.Forms.Button loginButton;
         private System.Windows.Forms.Label label3;
         private System.Windows.Forms.Button registrarButton;
     }
 }