namespace IFSPStore.App.Cadastros
{
    partial class CadastroCidades
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
            txtCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // txtCancelar
            // 
            txtCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtCancelar.Depth = 0;
            txtCancelar.HighEmphasis = true;
            txtCancelar.Icon = null;
            txtCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtCancelar.Location = new Point(365, 172);
            txtCancelar.Margin = new Padding(4, 6, 4, 6);
            txtCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtCancelar.Name = "txtCancelar";
            txtCancelar.NoAccentTextColor = Color.Empty;
            txtCancelar.Size = new Size(96, 36);
            txtCancelar.TabIndex = 5;
            txtCancelar.Text = "Cancelar";
            txtCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtCancelar.UseAccentColor = false;
            txtCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(487, 172);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Location = new Point(49, 159);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.LeadingIcon = null;
            txtId.Location = new Point(391, 90);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(312, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.Text = "id";
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(40, 90);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(312, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.Text = "Nome";
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // CadastroCidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtCancelar);
            Controls.Add(txtNome);
            Controls.Add(cboEstado);
            Controls.Add(txtId);
            Name = "CadastroCidades";
            Text = "Cadastro de Cidades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialButton txtCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
    }
}