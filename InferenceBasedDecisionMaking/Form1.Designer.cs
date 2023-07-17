namespace InferenceBasedDecisionMaking
{
    partial class Form1
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
            ifThen = new Button();
            orBtn = new Button();
            andBtn = new Button();
            EventAdd = new Button();
            inputBox = new GroupBox();
            InputText = new TextBox();
            EventDropdown = new ComboBox();
            EventCreateInp = new TextBox();
            EventCreate = new Button();
            EventList = new GroupBox();
            EventListbox = new TextBox();
            EndBtn = new Button();
            Begin = new Button();
            Undo = new Button();
            clearBtn = new Button();
            Negate = new Button();
            translation = new GroupBox();
            translationBox = new TextBox();
            Conclusion = new Button();
            inputBox.SuspendLayout();
            EventList.SuspendLayout();
            translation.SuspendLayout();
            SuspendLayout();
            // 
            // ifThen
            // 
            ifThen.Location = new Point(88, 54);
            ifThen.Name = "ifThen";
            ifThen.Size = new Size(94, 29);
            ifThen.TabIndex = 0;
            ifThen.Text = "If";
            ifThen.UseVisualStyleBackColor = true;
            ifThen.Click += ifThen_Click;
            // 
            // orBtn
            // 
            orBtn.Enabled = false;
            orBtn.Location = new Point(204, 54);
            orBtn.Name = "orBtn";
            orBtn.Size = new Size(94, 29);
            orBtn.TabIndex = 1;
            orBtn.Text = "OR";
            orBtn.UseVisualStyleBackColor = true;
            orBtn.Click += orBtn_Click;
            // 
            // andBtn
            // 
            andBtn.Enabled = false;
            andBtn.Location = new Point(314, 54);
            andBtn.Name = "andBtn";
            andBtn.Size = new Size(94, 29);
            andBtn.TabIndex = 2;
            andBtn.Text = "AND";
            andBtn.UseVisualStyleBackColor = true;
            andBtn.Click += andBtn_Click;
            // 
            // EventAdd
            // 
            EventAdd.Location = new Point(283, 89);
            EventAdd.Name = "EventAdd";
            EventAdd.Size = new Size(94, 29);
            EventAdd.TabIndex = 3;
            EventAdd.Text = "Add Event";
            EventAdd.UseVisualStyleBackColor = true;
            EventAdd.Click += EventAdd_Click;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(InputText);
            inputBox.Location = new Point(59, 133);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(431, 307);
            inputBox.TabIndex = 4;
            inputBox.TabStop = false;
            inputBox.Text = "Input";
            // 
            // InputText
            // 
            InputText.Location = new Point(6, 26);
            InputText.Multiline = true;
            InputText.Name = "InputText";
            InputText.ReadOnly = true;
            InputText.Size = new Size(419, 265);
            InputText.TabIndex = 0;
            // 
            // EventDropdown
            // 
            EventDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            EventDropdown.FormattingEnabled = true;
            EventDropdown.Location = new Point(59, 89);
            EventDropdown.Name = "EventDropdown";
            EventDropdown.Size = new Size(206, 28);
            EventDropdown.TabIndex = 5;
            // 
            // EventCreateInp
            // 
            EventCreateInp.Location = new Point(511, 19);
            EventCreateInp.Multiline = true;
            EventCreateInp.Name = "EventCreateInp";
            EventCreateInp.Size = new Size(250, 64);
            EventCreateInp.TabIndex = 6;
            // 
            // EventCreate
            // 
            EventCreate.Location = new Point(511, 89);
            EventCreate.Name = "EventCreate";
            EventCreate.Size = new Size(250, 29);
            EventCreate.TabIndex = 7;
            EventCreate.Text = "Create Event";
            EventCreate.UseVisualStyleBackColor = true;
            EventCreate.Click += EventCreate_Click;
            // 
            // EventList
            // 
            EventList.Controls.Add(EventListbox);
            EventList.Location = new Point(511, 133);
            EventList.Name = "EventList";
            EventList.Size = new Size(250, 351);
            EventList.TabIndex = 8;
            EventList.TabStop = false;
            EventList.Text = "Events";
            // 
            // EventListbox
            // 
            EventListbox.Location = new Point(6, 26);
            EventListbox.Multiline = true;
            EventListbox.Name = "EventListbox";
            EventListbox.ReadOnly = true;
            EventListbox.Size = new Size(238, 319);
            EventListbox.TabIndex = 0;
            // 
            // EndBtn
            // 
            EndBtn.Enabled = false;
            EndBtn.Location = new Point(88, 19);
            EndBtn.Name = "EndBtn";
            EndBtn.Size = new Size(94, 29);
            EndBtn.TabIndex = 9;
            EndBtn.Text = "End";
            EndBtn.UseVisualStyleBackColor = true;
            EndBtn.Click += EndBtn_Click;
            // 
            // Begin
            // 
            Begin.Enabled = false;
            Begin.Location = new Point(59, 455);
            Begin.Name = "Begin";
            Begin.Size = new Size(239, 29);
            Begin.TabIndex = 10;
            Begin.Text = "Translate";
            Begin.UseVisualStyleBackColor = true;
            Begin.Click += Begin_Click;
            // 
            // Undo
            // 
            Undo.Location = new Point(204, 19);
            Undo.Name = "Undo";
            Undo.Size = new Size(94, 29);
            Undo.TabIndex = 11;
            Undo.Text = "Undo";
            Undo.UseVisualStyleBackColor = true;
            Undo.Click += Undo_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(304, 455);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(186, 29);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Negate
            // 
            Negate.Location = new Point(396, 89);
            Negate.Name = "Negate";
            Negate.Size = new Size(94, 29);
            Negate.TabIndex = 12;
            Negate.Text = "Negate";
            Negate.UseVisualStyleBackColor = true;
            Negate.Click += Negate_Click;
            // 
            // translation
            // 
            translation.Controls.Add(translationBox);
            translation.Location = new Point(767, 18);
            translation.Name = "translation";
            translation.Size = new Size(240, 466);
            translation.TabIndex = 13;
            translation.TabStop = false;
            translation.Text = "Translation";
            // 
            // translationBox
            // 
            translationBox.Location = new Point(6, 26);
            translationBox.Multiline = true;
            translationBox.Name = "translationBox";
            translationBox.ReadOnly = true;
            translationBox.ScrollBars = ScrollBars.Horizontal;
            translationBox.Size = new Size(228, 434);
            translationBox.TabIndex = 0;
            // 
            // Conclusion
            // 
            Conclusion.Enabled = false;
            Conclusion.Location = new Point(314, 19);
            Conclusion.Name = "Conclusion";
            Conclusion.Size = new Size(94, 29);
            Conclusion.TabIndex = 15;
            Conclusion.Text = "Therefore";
            Conclusion.UseVisualStyleBackColor = true;
            Conclusion.Click += Conclusion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 520);
            Controls.Add(Conclusion);
            Controls.Add(translation);
            Controls.Add(Negate);
            Controls.Add(clearBtn);
            Controls.Add(Undo);
            Controls.Add(Begin);
            Controls.Add(EndBtn);
            Controls.Add(EventList);
            Controls.Add(EventCreate);
            Controls.Add(EventCreateInp);
            Controls.Add(EventDropdown);
            Controls.Add(inputBox);
            Controls.Add(EventAdd);
            Controls.Add(andBtn);
            Controls.Add(orBtn);
            Controls.Add(ifThen);
            Name = "Form1";
            Text = "Inference-Based Project";
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            EventList.ResumeLayout(false);
            EventList.PerformLayout();
            translation.ResumeLayout(false);
            translation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ifThen;
        private Button orBtn;
        private Button andBtn;
        private Button EventAdd;
        private GroupBox inputBox;
        private ComboBox EventDropdown;
        private TextBox EventCreateInp;
        private Button EventCreate;
        private GroupBox EventList;
        private Button EndBtn;
        private Button Begin;
        private TextBox InputText;
        private Button Undo;
        private Button clearBtn;
        private TextBox EventListbox;
        private Button Negate;
        private GroupBox translation;
        private TextBox translationBox;
        private Button Conclusion;
    }
}