namespace FFmpeg_Joiner
{
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddFile = new System.Windows.Forms.Button();
            this.FFmpeg_Join = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OutPath = new System.Windows.Forms.Label();
            this.OpenPath = new System.Windows.Forms.Label();
            this.OutExtendName = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.Label();
            this.filelist = new System.Windows.Forms.ListBox();
            this.OpenName = new System.Windows.Forms.Label();
            this.Clean = new System.Windows.Forms.Button();
            this.Notice1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_MIN = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.button_MAX = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddFile
            // 
            this.AddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddFile.FlatAppearance.BorderSize = 0;
            this.AddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddFile.ForeColor = System.Drawing.Color.White;
            this.AddFile.Location = new System.Drawing.Point(23, 67);
            this.AddFile.Margin = new System.Windows.Forms.Padding(4);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(173, 63);
            this.AddFile.TabIndex = 1;
            this.AddFile.Text = "Añadir videos";
            this.AddFile.UseVisualStyleBackColor = false;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // FFmpeg_Join
            // 
            this.FFmpeg_Join.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.FFmpeg_Join.FlatAppearance.BorderSize = 0;
            this.FFmpeg_Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFmpeg_Join.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FFmpeg_Join.ForeColor = System.Drawing.Color.White;
            this.FFmpeg_Join.Location = new System.Drawing.Point(204, 67);
            this.FFmpeg_Join.Margin = new System.Windows.Forms.Padding(4);
            this.FFmpeg_Join.Name = "FFmpeg_Join";
            this.FFmpeg_Join.Size = new System.Drawing.Size(173, 63);
            this.FFmpeg_Join.TabIndex = 2;
            this.FFmpeg_Join.Text = "Comenzar a fusionar";
            this.FFmpeg_Join.UseVisualStyleBackColor = false;
            this.FFmpeg_Join.Click += new System.EventHandler(this.FFmpeg_Join_Click);
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Information.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Information.Location = new System.Drawing.Point(16, 701);
            this.Information.Margin = new System.Windows.Forms.Padding(4);
            this.Information.Multiline = true;
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(1121, 168);
            this.Information.TabIndex = 5;
            this.Information.Text = "Información de las salidas de FFmpeg...\r\n";
            this.Information.TextChanged += new System.EventHandler(this.Information_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OutPath
            // 
            this.OutPath.AutoSize = true;
            this.OutPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutPath.Location = new System.Drawing.Point(1179, 32);
            this.OutPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutPath.Name = "OutPath";
            this.OutPath.Size = new System.Drawing.Size(54, 16);
            this.OutPath.TabIndex = 0;
            this.OutPath.Text = "OutPath";
            this.OutPath.Visible = false;
            // 
            // OpenPath
            // 
            this.OpenPath.AutoSize = true;
            this.OpenPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenPath.Location = new System.Drawing.Point(1179, 92);
            this.OpenPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenPath.Name = "OpenPath";
            this.OpenPath.Size = new System.Drawing.Size(67, 16);
            this.OpenPath.TabIndex = 13;
            this.OpenPath.Text = "OpenPath";
            this.OpenPath.Visible = false;
            // 
            // OutExtendName
            // 
            this.OutExtendName.AutoSize = true;
            this.OutExtendName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutExtendName.Location = new System.Drawing.Point(1179, 118);
            this.OutExtendName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutExtendName.Name = "OutExtendName";
            this.OutExtendName.Size = new System.Drawing.Size(105, 16);
            this.OutExtendName.TabIndex = 14;
            this.OutExtendName.Text = "OutExtendName";
            this.OutExtendName.Visible = false;
            // 
            // Command
            // 
            this.Command.AutoSize = true;
            this.Command.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Command.Location = new System.Drawing.Point(1179, 142);
            this.Command.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(69, 16);
            this.Command.TabIndex = 15;
            this.Command.Text = "Command";
            this.Command.Visible = false;
            // 
            // filelist
            // 
            this.filelist.AllowDrop = true;
            this.filelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.filelist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filelist.Cursor = System.Windows.Forms.Cursors.Default;
            this.filelist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.filelist.FormattingEnabled = true;
            this.filelist.ItemHeight = 16;
            this.filelist.Location = new System.Drawing.Point(16, 162);
            this.filelist.Margin = new System.Windows.Forms.Padding(4);
            this.filelist.Name = "filelist";
            this.filelist.Size = new System.Drawing.Size(1206, 530);
            this.filelist.TabIndex = 4;
            this.filelist.DragDrop += new System.Windows.Forms.DragEventHandler(this.filelist_DragDrop);
            this.filelist.DragEnter += new System.Windows.Forms.DragEventHandler(this.filelist_DragEnter);
            this.filelist.DragOver += new System.Windows.Forms.DragEventHandler(this.filelist_DragOver);
            // 
            // OpenName
            // 
            this.OpenName.AutoSize = true;
            this.OpenName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenName.Location = new System.Drawing.Point(1179, 12);
            this.OpenName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OpenName.Name = "OpenName";
            this.OpenName.Size = new System.Drawing.Size(77, 16);
            this.OpenName.TabIndex = 17;
            this.OpenName.Text = "OpenName";
            this.OpenName.Visible = false;
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Clean.FlatAppearance.BorderSize = 0;
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clean.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Clean.ForeColor = System.Drawing.Color.White;
            this.Clean.Location = new System.Drawing.Point(385, 67);
            this.Clean.Margin = new System.Windows.Forms.Padding(4);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(173, 63);
            this.Clean.TabIndex = 3;
            this.Clean.Text = "Vaciar la lista";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Notice1
            // 
            this.Notice1.AutoEllipsis = true;
            this.Notice1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Notice1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Notice1.Location = new System.Drawing.Point(748, 67);
            this.Notice1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Notice1.Name = "Notice1";
            this.Notice1.Size = new System.Drawing.Size(400, 63);
            this.Notice1.TabIndex = 19;
            this.Notice1.Text = "Basado en ffmpeg que admite la fusión de varios formatos de vídeo y admite la fus" +
    "ión en diferentes formatos de encapsulación.";
            this.Notice1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Notice1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(17, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "*Arrastrables";
            // 
            // Sort
            // 
            this.Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Sort.FlatAppearance.BorderSize = 0;
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sort.ForeColor = System.Drawing.Color.White;
            this.Sort.Location = new System.Drawing.Point(567, 67);
            this.Sort.Margin = new System.Windows.Forms.Padding(4);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(173, 63);
            this.Sort.TabIndex = 21;
            this.Sort.Text = "Ordenación automática";
            this.Sort.UseVisualStyleBackColor = false;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fusión de vídeo sin pérdidas por FFmpeg";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // button_MIN
            // 
            this.button_MIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MIN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_MIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_MIN.FlatAppearance.BorderSize = 0;
            this.button_MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MIN.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_MIN.ForeColor = System.Drawing.Color.White;
            this.button_MIN.Location = new System.Drawing.Point(1065, 1);
            this.button_MIN.Margin = new System.Windows.Forms.Padding(0);
            this.button_MIN.Name = "button_MIN";
            this.button_MIN.Size = new System.Drawing.Size(60, 34);
            this.button_MIN.TabIndex = 102;
            this.button_MIN.Text = "-";
            this.button_MIN.UseVisualStyleBackColor = false;
            this.button_MIN.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_EXIT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button_EXIT.FlatAppearance.BorderSize = 0;
            this.button_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EXIT.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_EXIT.ForeColor = System.Drawing.Color.White;
            this.button_EXIT.Location = new System.Drawing.Point(1182, 1);
            this.button_EXIT.Margin = new System.Windows.Forms.Padding(0);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(57, 34);
            this.button_EXIT.TabIndex = 103;
            this.button_EXIT.Text = "X";
            this.button_EXIT.UseVisualStyleBackColor = false;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // button_MAX
            // 
            this.button_MAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MAX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_MAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_MAX.FlatAppearance.BorderSize = 0;
            this.button_MAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MAX.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_MAX.ForeColor = System.Drawing.Color.White;
            this.button_MAX.Location = new System.Drawing.Point(1125, 1);
            this.button_MAX.Margin = new System.Windows.Forms.Padding(0);
            this.button_MAX.Name = "button_MAX";
            this.button_MAX.Size = new System.Drawing.Size(57, 34);
            this.button_MAX.TabIndex = 104;
            this.button_MAX.Text = "+";
            this.button_MAX.UseVisualStyleBackColor = false;
            this.button_MAX.Click += new System.EventHandler(this.button_MAX_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnVaciar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVaciar.ForeColor = System.Drawing.Color.White;
            this.btnVaciar.FlatAppearance.BorderSize = 0;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.Location = new System.Drawing.Point(1144, 701);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(78, 168);
            this.btnVaciar.TabIndex = 105;
            this.btnVaciar.Text = "Vaciar el mensaje";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1239, 882);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.button_MAX);
            this.Controls.Add(this.button_MIN);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Notice1);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.OpenName);
            this.Controls.Add(this.filelist);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.OutExtendName);
            this.Controls.Add(this.OpenPath);
            this.Controls.Add(this.OutPath);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.FFmpeg_Join);
            this.Controls.Add(this.AddFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fusión de vídeo sin pérdidas por FFmpeg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.Button AddFile;

		private global::System.Windows.Forms.Button FFmpeg_Join;

		private global::System.Windows.Forms.TextBox Information;

		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		private global::System.Windows.Forms.Label OutPath;

		private global::System.Windows.Forms.Label OpenPath;

		private global::System.Windows.Forms.Label OutExtendName;

		private global::System.Windows.Forms.Label Command;

		private global::System.Windows.Forms.ListBox filelist;

		private global::System.Windows.Forms.Label OpenName;

		private global::System.Windows.Forms.Button Clean;

		private global::System.Windows.Forms.Label Notice1;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Button Sort;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Button button_MIN;

		private global::System.Windows.Forms.Button button_EXIT;

		private global::System.Windows.Forms.Button button_MAX;
        private System.Windows.Forms.Button btnVaciar;
    }
}
