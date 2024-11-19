namespace FormPrincipal.Base
{
    partial class BaseForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            baseTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabCadastrar = new TabPage();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnCadastrar = new ReaLTaiizor.Controls.MaterialButton();
            tabConsultar = new TabPage();
            listView1 = new ListView();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            baseTabControl.SuspendLayout();
            tabCadastrar.SuspendLayout();
            tabConsultar.SuspendLayout();
            SuspendLayout();
            // 
            // baseTabControl
            // 
            baseTabControl.Controls.Add(tabCadastrar);
            baseTabControl.Controls.Add(tabConsultar);
            baseTabControl.Depth = 0;
            baseTabControl.Dock = DockStyle.Fill;
            baseTabControl.ImageList = imageList1;
            baseTabControl.Location = new Point(3, 64);
            baseTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            baseTabControl.Multiline = true;
            baseTabControl.Name = "baseTabControl";
            baseTabControl.SelectedIndex = 0;
            baseTabControl.Size = new Size(794, 383);
            baseTabControl.TabIndex = 0;
            // 
            // tabCadastrar
            // 
            tabCadastrar.Controls.Add(btnCancelar);
            tabCadastrar.Controls.Add(btnCadastrar);
            tabCadastrar.ImageKey = "form.png";
            tabCadastrar.Location = new Point(4, 31);
            tabCadastrar.Name = "tabCadastrar";
            tabCadastrar.Padding = new Padding(3);
            tabCadastrar.Size = new Size(786, 348);
            tabCadastrar.TabIndex = 0;
            tabCadastrar.Text = "Cadastrar";
            tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(683, 303);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrar.Depth = 0;
            btnCadastrar.HighEmphasis = true;
            btnCadastrar.Icon = null;
            btnCadastrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadastrar.Location = new Point(569, 303);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = Color.Empty;
            btnCadastrar.Size = new Size(106, 36);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // tabConsultar
            // 
            tabConsultar.Controls.Add(listView1);
            tabConsultar.Controls.Add(btnEditar);
            tabConsultar.Controls.Add(btnNovo);
            tabConsultar.Controls.Add(btnSalvar);
            tabConsultar.ImageKey = "search.png";
            tabConsultar.Location = new Point(4, 31);
            tabConsultar.Name = "tabConsultar";
            tabConsultar.Padding = new Padding(3);
            tabConsultar.Size = new Size(786, 348);
            tabConsultar.TabIndex = 1;
            tabConsultar.Text = "Consultar";
            tabConsultar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Top;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(780, 291);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(687, 303);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(595, 303);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "NOVO";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(489, 303);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "SALVAR";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search.png");
            imageList1.Images.SetKeyName(1, "form.png");
            imageList1.Images.SetKeyName(2, "baseline_fingerprint_black_24dp.png");
            imageList1.Images.SetKeyName(3, "logo.png");
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(baseTabControl);
            DrawerTabControl = baseTabControl;
            Name = "BaseForm";
            Text = "BaseForm";
            baseTabControl.ResumeLayout(false);
            tabCadastrar.ResumeLayout(false);
            tabCadastrar.PerformLayout();
            tabConsultar.ResumeLayout(false);
            tabConsultar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl baseTabControl;
        private TabPage tabCadastrar;
        private TabPage tabConsultar;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrar;
        private ListView listView1;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
    }
}