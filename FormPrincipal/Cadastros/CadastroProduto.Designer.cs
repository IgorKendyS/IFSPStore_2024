namespace IFSPStore.App.Cadastros
{
    partial class CadastroProduto
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUnVenda = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPreco = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataCompra = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialComboBox1);
            tabPageCadastro.Controls.Add(txtDataCompra);
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(txtUnVenda);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtUnVenda, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataCompra, 0);
            tabPageCadastro.Controls.SetChildIndex(materialComboBox1, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 28);
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
            txtNome.Size = new Size(669, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(683, 28);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(86, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtUnVenda
            // 
            txtUnVenda.AnimateReadOnly = false;
            txtUnVenda.AutoCompleteMode = AutoCompleteMode.None;
            txtUnVenda.AutoCompleteSource = AutoCompleteSource.None;
            txtUnVenda.BackgroundImageLayout = ImageLayout.None;
            txtUnVenda.CharacterCasing = CharacterCasing.Normal;
            txtUnVenda.Depth = 0;
            txtUnVenda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnVenda.HideSelection = true;
            txtUnVenda.Hint = "Unidade Venda";
            txtUnVenda.LeadingIcon = null;
            txtUnVenda.Location = new Point(270, 96);
            txtUnVenda.MaxLength = 32767;
            txtUnVenda.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnVenda.Name = "txtUnVenda";
            txtUnVenda.PasswordChar = '\0';
            txtUnVenda.PrefixSuffixText = null;
            txtUnVenda.ReadOnly = false;
            txtUnVenda.RightToLeft = RightToLeft.No;
            txtUnVenda.SelectedText = "";
            txtUnVenda.SelectionLength = 0;
            txtUnVenda.SelectionStart = 0;
            txtUnVenda.ShortcutsEnabled = true;
            txtUnVenda.Size = new Size(218, 48);
            txtUnVenda.TabIndex = 4;
            txtUnVenda.TabStop = false;
            txtUnVenda.TextAlign = HorizontalAlignment.Left;
            txtUnVenda.TrailingIcon = null;
            txtUnVenda.UseSystemPasswordChar = false;
            // 
            // txtPreco
            // 
            txtPreco.AllowPromptAsInput = true;
            txtPreco.AnimateReadOnly = false;
            txtPreco.AsciiOnly = false;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.BeepOnError = false;
            txtPreco.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HidePromptOnLeave = false;
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço";
            txtPreco.InsertKeyMode = InsertKeyMode.Default;
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(6, 96);
            txtPreco.Mask = "999.999,99";
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.PromptChar = '_';
            txtPreco.ReadOnly = false;
            txtPreco.RejectInputOnFirstFailure = false;
            txtPreco.ResetOnPrompt = true;
            txtPreco.ResetOnSpace = true;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(258, 48);
            txtPreco.SkipLiterals = true;
            txtPreco.TabIndex = 5;
            txtPreco.TabStop = false;
            txtPreco.Text = "   ,   .";
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            txtPreco.ValidatingType = null;
            // 
            // txtDataCompra
            // 
            txtDataCompra.AllowPromptAsInput = true;
            txtDataCompra.AnimateReadOnly = false;
            txtDataCompra.AsciiOnly = false;
            txtDataCompra.BackgroundImageLayout = ImageLayout.None;
            txtDataCompra.BeepOnError = false;
            txtDataCompra.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCompra.Depth = 0;
            txtDataCompra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCompra.HidePromptOnLeave = false;
            txtDataCompra.HideSelection = true;
            txtDataCompra.Hint = "Data Compra";
            txtDataCompra.InsertKeyMode = InsertKeyMode.Default;
            txtDataCompra.LeadingIcon = null;
            txtDataCompra.Location = new Point(494, 96);
            txtDataCompra.Mask = "99/99/9999";
            txtDataCompra.MaxLength = 32767;
            txtDataCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCompra.Name = "txtDataCompra";
            txtDataCompra.PasswordChar = '\0';
            txtDataCompra.PrefixSuffixText = null;
            txtDataCompra.PromptChar = '_';
            txtDataCompra.ReadOnly = false;
            txtDataCompra.RejectInputOnFirstFailure = false;
            txtDataCompra.ResetOnPrompt = true;
            txtDataCompra.ResetOnSpace = true;
            txtDataCompra.RightToLeft = RightToLeft.No;
            txtDataCompra.SelectedText = "";
            txtDataCompra.SelectionLength = 0;
            txtDataCompra.SelectionStart = 0;
            txtDataCompra.ShortcutsEnabled = true;
            txtDataCompra.Size = new Size(285, 48);
            txtDataCompra.SkipLiterals = true;
            txtDataCompra.TabIndex = 6;
            txtDataCompra.TabStop = false;
            txtDataCompra.Text = "  /  /";
            txtDataCompra.TextAlign = HorizontalAlignment.Left;
            txtDataCompra.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCompra.TrailingIcon = null;
            txtDataCompra.UseSystemPasswordChar = false;
            txtDataCompra.ValidatingType = null;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(6, 162);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(773, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 7;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataCompra;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPreco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnVenda;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}