namespace Alumbrado
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_load = new System.Windows.Forms.Button();
            this.bt_validate = new System.Windows.Forms.Button();
            this.bt_publish = new System.Windows.Forms.Button();
            this.ofd_source = new System.Windows.Forms.OpenFileDialog();
            this.lb_r_file = new System.Windows.Forms.Label();
            this.lb_file = new System.Windows.Forms.Label();
            this.lb_valid = new System.Windows.Forms.Label();
            this.lb_r_valid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(28, 49);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(75, 23);
            this.bt_load.TabIndex = 0;
            this.bt_load.Text = "Cargar";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // bt_validate
            // 
            this.bt_validate.Location = new System.Drawing.Point(28, 99);
            this.bt_validate.Name = "bt_validate";
            this.bt_validate.Size = new System.Drawing.Size(75, 23);
            this.bt_validate.TabIndex = 1;
            this.bt_validate.Text = "Validate";
            this.bt_validate.UseVisualStyleBackColor = true;
            this.bt_validate.Click += new System.EventHandler(this.bt_validate_Click);
            // 
            // bt_publish
            // 
            this.bt_publish.Enabled = false;
            this.bt_publish.Location = new System.Drawing.Point(28, 155);
            this.bt_publish.Name = "bt_publish";
            this.bt_publish.Size = new System.Drawing.Size(75, 23);
            this.bt_publish.TabIndex = 2;
            this.bt_publish.Text = "Publicar";
            this.bt_publish.UseVisualStyleBackColor = true;
            this.bt_publish.Click += new System.EventHandler(this.bt_publish_Click);
            // 
            // ofd_source
            // 
            this.ofd_source.FileName = "ofd_source";
            // 
            // lb_r_file
            // 
            this.lb_r_file.AutoSize = true;
            this.lb_r_file.Location = new System.Drawing.Point(157, 53);
            this.lb_r_file.Name = "lb_r_file";
            this.lb_r_file.Size = new System.Drawing.Size(51, 15);
            this.lb_r_file.TabIndex = 3;
            this.lb_r_file.Text = "Archivo:";
            // 
            // lb_file
            // 
            this.lb_file.AutoSize = true;
            this.lb_file.Location = new System.Drawing.Point(214, 53);
            this.lb_file.Name = "lb_file";
            this.lb_file.Size = new System.Drawing.Size(12, 15);
            this.lb_file.TabIndex = 4;
            this.lb_file.Text = "-";
            // 
            // lb_valid
            // 
            this.lb_valid.AutoSize = true;
            this.lb_valid.Location = new System.Drawing.Point(214, 103);
            this.lb_valid.Name = "lb_valid";
            this.lb_valid.Size = new System.Drawing.Size(12, 15);
            this.lb_valid.TabIndex = 6;
            this.lb_valid.Text = "-";
            // 
            // lb_r_valid
            // 
            this.lb_r_valid.AutoSize = true;
            this.lb_r_valid.Location = new System.Drawing.Point(157, 103);
            this.lb_r_valid.Name = "lb_r_valid";
            this.lb_r_valid.Size = new System.Drawing.Size(42, 15);
            this.lb_r_valid.TabIndex = 5;
            this.lb_r_valid.Text = "Valido:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_valid);
            this.Controls.Add(this.lb_r_valid);
            this.Controls.Add(this.lb_file);
            this.Controls.Add(this.lb_r_file);
            this.Controls.Add(this.bt_publish);
            this.Controls.Add(this.bt_validate);
            this.Controls.Add(this.bt_load);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bt_load;
        private Button bt_validate;
        private Button bt_publish;
        private OpenFileDialog ofd_source;
        private Label lb_r_file;
        private Label lb_file;
        private Label lb_valid;
        private Label lb_r_valid;
    }
}