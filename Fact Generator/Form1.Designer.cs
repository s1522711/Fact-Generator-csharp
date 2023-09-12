namespace Fact_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation4 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.OutputTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.GenerateBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LangSelBox = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.GerSelLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.EngSelLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.GerSel = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.EngSel = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.FactType = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.RandomFactSelLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DayFactSel = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.RandomFactSel = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.DayFactSelLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.LangSelBox.SuspendLayout();
            this.FactType.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.AcceptsReturn = false;
            this.OutputTextBox.AcceptsTab = false;
            this.OutputTextBox.AnimationSpeed = 200;
            this.OutputTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.OutputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.OutputTextBox.BackColor = System.Drawing.Color.White;
            this.OutputTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OutputTextBox.BackgroundImage")));
            this.OutputTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.OutputTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OutputTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.OutputTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.OutputTextBox.BorderRadius = 1;
            this.OutputTextBox.BorderThickness = 1;
            this.OutputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.OutputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.OutputTextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.OutputTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.DefaultText = "Click the generate button to generate a fact!";
            this.OutputTextBox.FillColor = System.Drawing.Color.White;
            this.OutputTextBox.HideSelection = true;
            this.OutputTextBox.IconLeft = null;
            this.OutputTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputTextBox.IconPadding = 10;
            this.OutputTextBox.IconRight = null;
            this.OutputTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputTextBox.Lines = new string[] {
        "Click the generate button to generate a fact!"};
            this.OutputTextBox.Location = new System.Drawing.Point(247, 12);
            this.OutputTextBox.MaxLength = 32767;
            this.OutputTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.OutputTextBox.Modified = false;
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.OutputTextBox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.OutputTextBox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.OutputTextBox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.OutputTextBox.OnIdleState = stateProperties16;
            this.OutputTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.OutputTextBox.PasswordChar = '\0';
            this.OutputTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.OutputTextBox.PlaceholderText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.SelectionLength = 0;
            this.OutputTextBox.SelectionStart = 45;
            this.OutputTextBox.ShortcutsEnabled = true;
            this.OutputTextBox.Size = new System.Drawing.Size(341, 212);
            this.OutputTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OutputTextBox.TextMarginBottom = 0;
            this.OutputTextBox.TextMarginLeft = 3;
            this.OutputTextBox.TextMarginTop = 0;
            this.OutputTextBox.TextPlaceholder = "";
            this.OutputTextBox.UseSystemPasswordChar = false;
            this.OutputTextBox.WordWrap = true;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.AllowAnimations = true;
            this.GenerateBtn.AllowMouseEffects = true;
            this.GenerateBtn.AllowToggling = false;
            this.GenerateBtn.AnimationSpeed = 200;
            this.GenerateBtn.AutoGenerateColors = false;
            this.GenerateBtn.AutoRoundBorders = false;
            this.GenerateBtn.AutoSizeLeftIcon = true;
            this.GenerateBtn.AutoSizeRightIcon = true;
            this.GenerateBtn.BackColor = System.Drawing.Color.Transparent;
            this.GenerateBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.GenerateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenerateBtn.BackgroundImage")));
            this.GenerateBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateBtn.ButtonText = "Generate!";
            this.GenerateBtn.ButtonTextMarginLeft = 0;
            this.GenerateBtn.ColorContrastOnClick = 45;
            this.GenerateBtn.ColorContrastOnHover = 45;
            this.GenerateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.GenerateBtn.CustomizableEdges = borderEdges4;
            this.bunifuTransition1.SetDecoration(this.GenerateBtn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.GenerateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GenerateBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.GenerateBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GenerateBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.GenerateBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.GenerateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.GenerateBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.GenerateBtn.IconMarginLeft = 11;
            this.GenerateBtn.IconPadding = 10;
            this.GenerateBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenerateBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.GenerateBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.GenerateBtn.IconSize = 25;
            this.GenerateBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.GenerateBtn.IdleBorderRadius = 1;
            this.GenerateBtn.IdleBorderThickness = 1;
            this.GenerateBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.GenerateBtn.IdleIconLeftImage = null;
            this.GenerateBtn.IdleIconRightImage = null;
            this.GenerateBtn.IndicateFocus = false;
            this.GenerateBtn.Location = new System.Drawing.Point(12, 12);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.GenerateBtn.OnDisabledState.BorderRadius = 1;
            this.GenerateBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateBtn.OnDisabledState.BorderThickness = 1;
            this.GenerateBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GenerateBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.GenerateBtn.OnDisabledState.IconLeftImage = null;
            this.GenerateBtn.OnDisabledState.IconRightImage = null;
            this.GenerateBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.GenerateBtn.onHoverState.BorderRadius = 1;
            this.GenerateBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateBtn.onHoverState.BorderThickness = 1;
            this.GenerateBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.GenerateBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.GenerateBtn.onHoverState.IconLeftImage = null;
            this.GenerateBtn.onHoverState.IconRightImage = null;
            this.GenerateBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.GenerateBtn.OnIdleState.BorderRadius = 1;
            this.GenerateBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateBtn.OnIdleState.BorderThickness = 1;
            this.GenerateBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.GenerateBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.GenerateBtn.OnIdleState.IconLeftImage = null;
            this.GenerateBtn.OnIdleState.IconRightImage = null;
            this.GenerateBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.GenerateBtn.OnPressedState.BorderRadius = 1;
            this.GenerateBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateBtn.OnPressedState.BorderThickness = 1;
            this.GenerateBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.GenerateBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.GenerateBtn.OnPressedState.IconLeftImage = null;
            this.GenerateBtn.OnPressedState.IconRightImage = null;
            this.GenerateBtn.Size = new System.Drawing.Size(229, 39);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerateBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.GenerateBtn.TextMarginLeft = 0;
            this.GenerateBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.GenerateBtn.UseDefaultRadiusAndThickness = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // LangSelBox
            // 
            this.LangSelBox.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.LangSelBox.BorderColor = System.Drawing.Color.LightGray;
            this.LangSelBox.BorderRadius = 1;
            this.LangSelBox.BorderThickness = 1;
            this.LangSelBox.Controls.Add(this.GerSelLabel);
            this.LangSelBox.Controls.Add(this.EngSelLabel);
            this.LangSelBox.Controls.Add(this.GerSel);
            this.LangSelBox.Controls.Add(this.EngSel);
            this.bunifuTransition1.SetDecoration(this.LangSelBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LangSelBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LangSelBox.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LangSelBox.LabelIndent = 10;
            this.LangSelBox.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.LangSelBox.Location = new System.Drawing.Point(12, 57);
            this.LangSelBox.Name = "LangSelBox";
            this.LangSelBox.Size = new System.Drawing.Size(229, 79);
            this.LangSelBox.TabIndex = 2;
            this.LangSelBox.TabStop = false;
            this.LangSelBox.Text = "Language";
            // 
            // GerSelLabel
            // 
            this.GerSelLabel.AllowParentOverrides = false;
            this.GerSelLabel.AutoEllipsis = false;
            this.GerSelLabel.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.GerSelLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.GerSelLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GerSelLabel.Location = new System.Drawing.Point(33, 51);
            this.GerSelLabel.Name = "GerSelLabel";
            this.GerSelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GerSelLabel.Size = new System.Drawing.Size(42, 15);
            this.GerSelLabel.TabIndex = 4;
            this.GerSelLabel.Text = "German";
            this.GerSelLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.GerSelLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // EngSelLabel
            // 
            this.EngSelLabel.AllowParentOverrides = false;
            this.EngSelLabel.AutoEllipsis = false;
            this.EngSelLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.EngSelLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.EngSelLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.EngSelLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EngSelLabel.Location = new System.Drawing.Point(33, 24);
            this.EngSelLabel.Name = "EngSelLabel";
            this.EngSelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EngSelLabel.Size = new System.Drawing.Size(38, 15);
            this.EngSelLabel.TabIndex = 3;
            this.EngSelLabel.Text = "English";
            this.EngSelLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.EngSelLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // GerSel
            // 
            this.GerSel.AllowBindingControlLocation = false;
            this.GerSel.BackColor = System.Drawing.Color.Transparent;
            this.GerSel.BindingControl = this.LangSelBox;
            this.GerSel.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.GerSel.BorderThickness = 1;
            this.GerSel.Checked = false;
            this.bunifuTransition1.SetDecoration(this.GerSel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.GerSel.Location = new System.Drawing.Point(6, 49);
            this.GerSel.Name = "GerSel";
            this.GerSel.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.GerSel.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.GerSel.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.GerSel.RadioColor = System.Drawing.Color.DodgerBlue;
            this.GerSel.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.GerSel.Size = new System.Drawing.Size(21, 21);
            this.GerSel.TabIndex = 3;
            this.GerSel.Text = null;
            // 
            // EngSel
            // 
            this.EngSel.AllowBindingControlLocation = false;
            this.EngSel.BackColor = System.Drawing.Color.Transparent;
            this.EngSel.BindingControl = this.LangSelBox;
            this.EngSel.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.EngSel.BorderThickness = 1;
            this.EngSel.Checked = true;
            this.bunifuTransition1.SetDecoration(this.EngSel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.EngSel.Location = new System.Drawing.Point(6, 22);
            this.EngSel.Name = "EngSel";
            this.EngSel.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.EngSel.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EngSel.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.EngSel.RadioColor = System.Drawing.Color.DodgerBlue;
            this.EngSel.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EngSel.Size = new System.Drawing.Size(21, 21);
            this.EngSel.TabIndex = 3;
            this.EngSel.Text = null;
            // 
            // FactType
            // 
            this.FactType.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.FactType.BorderColor = System.Drawing.Color.LightGray;
            this.FactType.BorderRadius = 1;
            this.FactType.BorderThickness = 1;
            this.FactType.Controls.Add(this.DayFactSelLabel);
            this.FactType.Controls.Add(this.RandomFactSelLabel);
            this.FactType.Controls.Add(this.DayFactSel);
            this.FactType.Controls.Add(this.RandomFactSel);
            this.bunifuTransition1.SetDecoration(this.FactType, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FactType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FactType.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FactType.LabelIndent = 10;
            this.FactType.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.FactType.Location = new System.Drawing.Point(12, 142);
            this.FactType.Name = "FactType";
            this.FactType.Size = new System.Drawing.Size(229, 82);
            this.FactType.TabIndex = 3;
            this.FactType.TabStop = false;
            this.FactType.Text = "Type Of Fact";
            // 
            // RandomFactSelLabel
            // 
            this.RandomFactSelLabel.AllowParentOverrides = false;
            this.RandomFactSelLabel.AutoEllipsis = false;
            this.RandomFactSelLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RandomFactSelLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.RandomFactSelLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.RandomFactSelLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RandomFactSelLabel.Location = new System.Drawing.Point(33, 24);
            this.RandomFactSelLabel.Name = "RandomFactSelLabel";
            this.RandomFactSelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RandomFactSelLabel.Size = new System.Drawing.Size(70, 15);
            this.RandomFactSelLabel.TabIndex = 5;
            this.RandomFactSelLabel.Text = "Random Fact";
            this.RandomFactSelLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RandomFactSelLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.RandomFactSelLabel.Click += new System.EventHandler(this.RandomFactSelLabel_Click);
            // 
            // DayFactSel
            // 
            this.DayFactSel.AllowBindingControlLocation = false;
            this.DayFactSel.BackColor = System.Drawing.Color.Transparent;
            this.DayFactSel.BindingControl = this.FactType;
            this.DayFactSel.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.DayFactSel.BorderThickness = 1;
            this.DayFactSel.Checked = false;
            this.bunifuTransition1.SetDecoration(this.DayFactSel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DayFactSel.Location = new System.Drawing.Point(6, 49);
            this.DayFactSel.Name = "DayFactSel";
            this.DayFactSel.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.DayFactSel.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DayFactSel.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.DayFactSel.RadioColor = System.Drawing.Color.DodgerBlue;
            this.DayFactSel.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DayFactSel.Size = new System.Drawing.Size(21, 21);
            this.DayFactSel.TabIndex = 1;
            this.DayFactSel.Text = null;
            // 
            // RandomFactSel
            // 
            this.RandomFactSel.AllowBindingControlLocation = false;
            this.RandomFactSel.BackColor = System.Drawing.Color.Transparent;
            this.RandomFactSel.BindingControl = this.FactType;
            this.RandomFactSel.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.RandomFactSel.BorderThickness = 1;
            this.RandomFactSel.Checked = true;
            this.bunifuTransition1.SetDecoration(this.RandomFactSel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.RandomFactSel.Location = new System.Drawing.Point(6, 22);
            this.RandomFactSel.Name = "RandomFactSel";
            this.RandomFactSel.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.RandomFactSel.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RandomFactSel.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.RandomFactSel.RadioColor = System.Drawing.Color.DodgerBlue;
            this.RandomFactSel.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RandomFactSel.Size = new System.Drawing.Size(21, 21);
            this.RandomFactSel.TabIndex = 0;
            this.RandomFactSel.Text = null;
            // 
            // DayFactSelLabel
            // 
            this.DayFactSelLabel.AllowParentOverrides = false;
            this.DayFactSelLabel.AutoEllipsis = false;
            this.DayFactSelLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DayFactSelLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.DayFactSelLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DayFactSelLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DayFactSelLabel.Location = new System.Drawing.Point(33, 51);
            this.DayFactSelLabel.Name = "DayFactSelLabel";
            this.DayFactSelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DayFactSelLabel.Size = new System.Drawing.Size(78, 15);
            this.DayFactSelLabel.TabIndex = 6;
            this.DayFactSelLabel.Text = "Fact of the day";
            this.DayFactSelLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DayFactSelLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.DayFactSelLabel.Click += new System.EventHandler(this.DayFactSelLabel_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 236);
            this.Controls.Add(this.FactType);
            this.Controls.Add(this.LangSelBox);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.OutputTextBox);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fact Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.LangSelBox.ResumeLayout(false);
            this.LangSelBox.PerformLayout();
            this.FactType.ResumeLayout(false);
            this.FactType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox OutputTextBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton GenerateBtn;
        private Bunifu.UI.WinForms.BunifuGroupBox LangSelBox;
        private Bunifu.UI.WinForms.BunifuLabel EngSelLabel;
        private Bunifu.UI.WinForms.BunifuRadioButton GerSel;
        private Bunifu.UI.WinForms.BunifuRadioButton EngSel;
        private Bunifu.UI.WinForms.BunifuLabel GerSelLabel;
        private Bunifu.UI.WinForms.BunifuGroupBox FactType;
        private Bunifu.UI.WinForms.BunifuLabel RandomFactSelLabel;
        private Bunifu.UI.WinForms.BunifuRadioButton DayFactSel;
        private Bunifu.UI.WinForms.BunifuRadioButton RandomFactSel;
        private Bunifu.UI.WinForms.BunifuLabel DayFactSelLabel;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
    }
}

