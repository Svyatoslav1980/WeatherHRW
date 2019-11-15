namespace WeatherHRW
{
    partial class Weather
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
            this.getWeatherButton = new System.Windows.Forms.Button();
            this.timeZoneButton = new System.Windows.Forms.Button();
            this.weatherTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.jsonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cityCodeLabel = new System.Windows.Forms.Label();
            this.ZipCodeLabel = new System.Windows.Forms.Label();
            this.weatherGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.hummidityLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.degLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.requestsListButton = new System.Windows.Forms.Button();
            this.weatherGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getWeatherButton
            // 
            this.getWeatherButton.Location = new System.Drawing.Point(332, 295);
            this.getWeatherButton.Name = "getWeatherButton";
            this.getWeatherButton.Size = new System.Drawing.Size(101, 23);
            this.getWeatherButton.TabIndex = 0;
            this.getWeatherButton.Text = "Get weather";
            this.getWeatherButton.UseVisualStyleBackColor = true;
            this.getWeatherButton.Click += new System.EventHandler(this.getWeatherButton_Click);
            // 
            // timeZoneButton
            // 
            this.timeZoneButton.Location = new System.Drawing.Point(332, 321);
            this.timeZoneButton.Name = "timeZoneButton";
            this.timeZoneButton.Size = new System.Drawing.Size(101, 23);
            this.timeZoneButton.TabIndex = 1;
            this.timeZoneButton.Text = "Get location";
            this.timeZoneButton.UseVisualStyleBackColor = true;
            this.timeZoneButton.Click += new System.EventHandler(this.timeZoneButton_Click);
            // 
            // weatherTextBox
            // 
            this.weatherTextBox.Location = new System.Drawing.Point(81, 295);
            this.weatherTextBox.Name = "weatherTextBox";
            this.weatherTextBox.Size = new System.Drawing.Size(100, 20);
            this.weatherTextBox.TabIndex = 2;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(81, 321);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 3;
            // 
            // jsonRichTextBox
            // 
            this.jsonRichTextBox.Location = new System.Drawing.Point(13, 13);
            this.jsonRichTextBox.Name = "jsonRichTextBox";
            this.jsonRichTextBox.Size = new System.Drawing.Size(420, 96);
            this.jsonRichTextBox.TabIndex = 4;
            this.jsonRichTextBox.Text = "";
            // 
            // cityCodeLabel
            // 
            this.cityCodeLabel.AutoSize = true;
            this.cityCodeLabel.Location = new System.Drawing.Point(4, 297);
            this.cityCodeLabel.Name = "cityCodeLabel";
            this.cityCodeLabel.Size = new System.Drawing.Size(51, 13);
            this.cityCodeLabel.TabIndex = 5;
            this.cityCodeLabel.Text = "City code";
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Location = new System.Drawing.Point(4, 324);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(49, 13);
            this.ZipCodeLabel.TabIndex = 6;
            this.ZipCodeLabel.Text = "Zip code";
            // 
            // weatherGroupBox
            // 
            this.weatherGroupBox.Controls.Add(this.nameLabel);
            this.weatherGroupBox.Controls.Add(this.pressureLabel);
            this.weatherGroupBox.Controls.Add(this.hummidityLabel);
            this.weatherGroupBox.Controls.Add(this.descriptionLabel);
            this.weatherGroupBox.Controls.Add(this.tempLabel);
            this.weatherGroupBox.Controls.Add(this.iconPanel);
            this.weatherGroupBox.Location = new System.Drawing.Point(12, 115);
            this.weatherGroupBox.Name = "weatherGroupBox";
            this.weatherGroupBox.Size = new System.Drawing.Size(421, 110);
            this.weatherGroupBox.TabIndex = 7;
            this.weatherGroupBox.TabStop = false;
            this.weatherGroupBox.Text = "Weather";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(265, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 5;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(265, 34);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(0, 13);
            this.pressureLabel.TabIndex = 4;
            // 
            // hummidityLabel
            // 
            this.hummidityLabel.AutoSize = true;
            this.hummidityLabel.Location = new System.Drawing.Point(146, 91);
            this.hummidityLabel.Name = "hummidityLabel";
            this.hummidityLabel.Size = new System.Drawing.Size(0, 13);
            this.hummidityLabel.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(146, 70);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionLabel.TabIndex = 2;
            // 
            // tempLabel
            // 
            this.tempLabel.AllowDrop = true;
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(146, 34);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(0, 13);
            this.tempLabel.TabIndex = 1;
            // 
            // iconPanel
            // 
            this.iconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPanel.Location = new System.Drawing.Point(1, 14);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(90, 90);
            this.iconPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.degLabel);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 55);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wind";
            // 
            // degLabel
            // 
            this.degLabel.AutoSize = true;
            this.degLabel.Location = new System.Drawing.Point(234, 20);
            this.degLabel.Name = "degLabel";
            this.degLabel.Size = new System.Drawing.Size(0, 13);
            this.degLabel.TabIndex = 1;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(108, 20);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 13);
            this.speedLabel.TabIndex = 0;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(266, 321);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(48, 20);
            this.countryTextBox.TabIndex = 9;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(211, 324);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Country";
            // 
            // requestsListButton
            // 
            this.requestsListButton.Location = new System.Drawing.Point(332, 350);
            this.requestsListButton.Name = "requestsListButton";
            this.requestsListButton.Size = new System.Drawing.Size(101, 23);
            this.requestsListButton.TabIndex = 11;
            this.requestsListButton.Text = "Requests list";
            this.requestsListButton.UseVisualStyleBackColor = true;
            this.requestsListButton.Click += new System.EventHandler(this.requestsListButton_Click);
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 375);
            this.Controls.Add(this.requestsListButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.weatherGroupBox);
            this.Controls.Add(this.ZipCodeLabel);
            this.Controls.Add(this.cityCodeLabel);
            this.Controls.Add(this.jsonRichTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.weatherTextBox);
            this.Controls.Add(this.timeZoneButton);
            this.Controls.Add(this.getWeatherButton);
            this.Name = "Weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Weather_Load);
            this.weatherGroupBox.ResumeLayout(false);
            this.weatherGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getWeatherButton;
        private System.Windows.Forms.Button timeZoneButton;
        private System.Windows.Forms.TextBox weatherTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.RichTextBox jsonRichTextBox;
        private System.Windows.Forms.Label cityCodeLabel;
        private System.Windows.Forms.Label ZipCodeLabel;
        private System.Windows.Forms.GroupBox weatherGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label hummidityLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label degLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button requestsListButton;
    }
}

