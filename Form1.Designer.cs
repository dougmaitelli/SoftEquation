namespace SoftEquation
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
            System.Windows.Forms.ToolStripMenuItem MenuAdicionarEquacao;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImportarEquacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportarEquacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExportarImagens = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaTextoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdicionarExercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditarEquacao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditarExercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExcluirEquacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuArquivoAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSugestoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBusca = new System.Windows.Forms.ToolStripTextBox();
            this.MenuBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ListMenuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ListMenuContextSelecionarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuContextSelecionarTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuContextAdicionarEquacao = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuContextAdicionarExercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuContextEditarEquacao = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuContextEditarExercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuContextExcluirEquacao = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMenuContextExcluirEquacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.Categoria = new System.Windows.Forms.Label();
            this.EquationBox = new System.Windows.Forms.PictureBox();
            this.ImageContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Titulo = new System.Windows.Forms.Label();
            this.BotaoExercicios = new System.Windows.Forms.Button();
            this.Descricao = new System.Windows.Forms.Label();
            this.DescricaoContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarParaTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportEquationsDialog = new System.Windows.Forms.OpenFileDialog();
            this.SoftEquationHelp = new System.Windows.Forms.HelpProvider();
            this.ExportEquationsDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExportImagesDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ExportTextDialog = new System.Windows.Forms.SaveFileDialog();
            MenuAdicionarEquacao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ListMenuContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquationBox)).BeginInit();
            this.ImageContext.SuspendLayout();
            this.DescricaoContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuAdicionarEquacao
            // 
            MenuAdicionarEquacao.Name = "MenuAdicionarEquacao";
            MenuAdicionarEquacao.Size = new System.Drawing.Size(174, 22);
            MenuAdicionarEquacao.Text = "Adicionar Equação";
            MenuAdicionarEquacao.Click += new System.EventHandler(this.MenuAdicionarEquacao_Click);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivo,
            this.MenuFerramentas,
            this.MenuAjuda,
            this.MenuBusca,
            this.MenuBuscar});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(624, 27);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuArquivo
            // 
            this.MenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImportarEquacoes,
            this.MenuExportarEquacoes,
            this.MenuExportarImagens,
            this.exportarParaTextoToolStripMenuItem1});
            this.MenuArquivo.Name = "MenuArquivo";
            this.MenuArquivo.Size = new System.Drawing.Size(61, 23);
            this.MenuArquivo.Text = "Arquivo";
            // 
            // MenuImportarEquacoes
            // 
            this.MenuImportarEquacoes.Name = "MenuImportarEquacoes";
            this.MenuImportarEquacoes.Size = new System.Drawing.Size(175, 22);
            this.MenuImportarEquacoes.Text = "Importar Equações";
            this.MenuImportarEquacoes.Click += new System.EventHandler(this.MenuImportarEquacoes_Click);
            // 
            // MenuExportarEquacoes
            // 
            this.MenuExportarEquacoes.Name = "MenuExportarEquacoes";
            this.MenuExportarEquacoes.Size = new System.Drawing.Size(175, 22);
            this.MenuExportarEquacoes.Text = "Exportar Equações";
            this.MenuExportarEquacoes.Click += new System.EventHandler(this.MenuExportarEquacoes_Click);
            // 
            // MenuExportarImagens
            // 
            this.MenuExportarImagens.Name = "MenuExportarImagens";
            this.MenuExportarImagens.Size = new System.Drawing.Size(175, 22);
            this.MenuExportarImagens.Text = "Exportar Imagens";
            this.MenuExportarImagens.Click += new System.EventHandler(this.MenuExportarImagens_Click);
            // 
            // exportarParaTextoToolStripMenuItem1
            // 
            this.exportarParaTextoToolStripMenuItem1.Name = "exportarParaTextoToolStripMenuItem1";
            this.exportarParaTextoToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.exportarParaTextoToolStripMenuItem1.Text = "Exportar para Texto";
            this.exportarParaTextoToolStripMenuItem1.Click += new System.EventHandler(this.exportarParaTextoToolStripMenuItem1_Click);
            // 
            // MenuFerramentas
            // 
            this.MenuFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            MenuAdicionarEquacao,
            this.MenuAdicionarExercicio,
            this.MenuEditarEquacao,
            this.MenuEditarExercicio,
            this.MenuExcluirEquacoes});
            this.MenuFerramentas.Name = "MenuFerramentas";
            this.MenuFerramentas.Size = new System.Drawing.Size(84, 23);
            this.MenuFerramentas.Text = "Ferramentas";
            // 
            // MenuAdicionarExercicio
            // 
            this.MenuAdicionarExercicio.Name = "MenuAdicionarExercicio";
            this.MenuAdicionarExercicio.Size = new System.Drawing.Size(174, 22);
            this.MenuAdicionarExercicio.Text = "Adicionar Exercício";
            this.MenuAdicionarExercicio.Click += new System.EventHandler(this.ListMenuContextAdicionarExercicio_Click);
            // 
            // MenuEditarEquacao
            // 
            this.MenuEditarEquacao.Name = "MenuEditarEquacao";
            this.MenuEditarEquacao.Size = new System.Drawing.Size(174, 22);
            this.MenuEditarEquacao.Text = "Editar Equação";
            this.MenuEditarEquacao.Click += new System.EventHandler(this.MenuEditarEquacao_Click);
            // 
            // MenuEditarExercicio
            // 
            this.MenuEditarExercicio.Name = "MenuEditarExercicio";
            this.MenuEditarExercicio.Size = new System.Drawing.Size(174, 22);
            this.MenuEditarExercicio.Text = "Editar Exercícios";
            this.MenuEditarExercicio.Click += new System.EventHandler(this.ListMenuContextEditarExercicios_Click);
            // 
            // MenuExcluirEquacoes
            // 
            this.MenuExcluirEquacoes.Name = "MenuExcluirEquacoes";
            this.MenuExcluirEquacoes.Size = new System.Drawing.Size(174, 22);
            this.MenuExcluirEquacoes.Text = "Excluir Equações";
            this.MenuExcluirEquacoes.Click += new System.EventHandler(this.MenuExcluirEquacoes_Click);
            // 
            // MenuAjuda
            // 
            this.MenuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivoAjuda,
            this.MenuSugestoes,
            this.MenuSobre});
            this.MenuAjuda.Name = "MenuAjuda";
            this.MenuAjuda.Size = new System.Drawing.Size(50, 23);
            this.MenuAjuda.Text = "Ajuda";
            // 
            // MenuArquivoAjuda
            // 
            this.MenuArquivoAjuda.Name = "MenuArquivoAjuda";
            this.MenuArquivoAjuda.Size = new System.Drawing.Size(166, 22);
            this.MenuArquivoAjuda.Text = "Arquivo de Ajuda";
            this.MenuArquivoAjuda.Click += new System.EventHandler(this.MenuArquivoAjuda_Click);
            // 
            // MenuSugestoes
            // 
            this.MenuSugestoes.Name = "MenuSugestoes";
            this.MenuSugestoes.Size = new System.Drawing.Size(166, 22);
            this.MenuSugestoes.Text = "Sugestões";
            this.MenuSugestoes.Click += new System.EventHandler(this.MenuSugestoes_Click);
            // 
            // MenuSobre
            // 
            this.MenuSobre.Name = "MenuSobre";
            this.MenuSobre.Size = new System.Drawing.Size(166, 22);
            this.MenuSobre.Text = "Sobre...";
            this.MenuSobre.Click += new System.EventHandler(this.MenuSobre_Click);
            // 
            // MenuBusca
            // 
            this.MenuBusca.Name = "MenuBusca";
            this.MenuBusca.Size = new System.Drawing.Size(100, 23);
            this.MenuBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuBusca_KeyDown);
            // 
            // MenuBuscar
            // 
            this.MenuBuscar.Name = "MenuBuscar";
            this.MenuBuscar.Size = new System.Drawing.Size(54, 23);
            this.MenuBuscar.Text = "Buscar";
            this.MenuBuscar.Click += new System.EventHandler(this.MenuBuscar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListMenu);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::SoftEquation.Properties.Resources.bgr;
            this.splitContainer1.Panel2.Controls.Add(this.Categoria);
            this.splitContainer1.Panel2.Controls.Add(this.EquationBox);
            this.splitContainer1.Panel2.Controls.Add(this.Titulo);
            this.splitContainer1.Panel2.Controls.Add(this.BotaoExercicios);
            this.splitContainer1.Panel2.Controls.Add(this.Descricao);
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainer1.Size = new System.Drawing.Size(624, 415);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            // 
            // ListMenu
            // 
            this.ListMenu.AllowColumnReorder = true;
            this.ListMenu.AllowDrop = true;
            this.ListMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.ListMenu.BackgroundImage = global::SoftEquation.Properties.Resources.bg;
            this.ListMenu.CheckBoxes = true;
            this.ListMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListMenu.ContextMenuStrip = this.ListMenuContext;
            this.ListMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMenu.ForeColor = System.Drawing.Color.White;
            this.ListMenu.Location = new System.Drawing.Point(0, 0);
            this.ListMenu.MultiSelect = false;
            this.ListMenu.Name = "ListMenu";
            this.ListMenu.Size = new System.Drawing.Size(200, 415);
            this.ListMenu.TabIndex = 0;
            this.ListMenu.UseCompatibleStateImageBehavior = false;
            this.ListMenu.View = System.Windows.Forms.View.Details;
            this.ListMenu.DoubleClick += new System.EventHandler(this.ListMenu_DoubleClick);
            this.ListMenu.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListMenu_DragDrop);
            this.ListMenu.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListMenu_DragEnter);
            this.ListMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListMenu_KeyDown);
            this.ListMenu.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListMenu_ItemDrag);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Criador";
            this.columnHeader2.Width = 63;
            // 
            // ListMenuContext
            // 
            this.ListMenuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListMenuContextSelecionarCategoria,
            this.ListMenuContextSelecionarTudo,
            this.ListMenuContextAdicionarEquacao,
            this.ListMenuContextAdicionarExercicio,
            this.ListMenuContextEditarEquacao,
            this.ListMenuContextEditarExercicio,
            this.ListMenuContextExcluirEquacao,
            this.ListMenuContextExcluirEquacoes});
            this.ListMenuContext.Name = "contextMenuStrip1";
            this.ListMenuContext.Size = new System.Drawing.Size(183, 180);
            // 
            // ListMenuContextSelecionarCategoria
            // 
            this.ListMenuContextSelecionarCategoria.Name = "ListMenuContextSelecionarCategoria";
            this.ListMenuContextSelecionarCategoria.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextSelecionarCategoria.Text = "Selecionar Categoria";
            this.ListMenuContextSelecionarCategoria.Click += new System.EventHandler(this.ListMenuContextSelecionarCategoria_Click);
            // 
            // ListMenuContextSelecionarTudo
            // 
            this.ListMenuContextSelecionarTudo.Name = "ListMenuContextSelecionarTudo";
            this.ListMenuContextSelecionarTudo.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextSelecionarTudo.Text = "Selecionar Tudo";
            this.ListMenuContextSelecionarTudo.Click += new System.EventHandler(this.ListMenuContextSelecionarTudo_Click);
            // 
            // ListMenuContextAdicionarEquacao
            // 
            this.ListMenuContextAdicionarEquacao.Name = "ListMenuContextAdicionarEquacao";
            this.ListMenuContextAdicionarEquacao.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextAdicionarEquacao.Text = "Adicionar Equação";
            this.ListMenuContextAdicionarEquacao.Click += new System.EventHandler(this.ListMenuContextAdicionarEquacao_Click);
            // 
            // ListMenuContextAdicionarExercicio
            // 
            this.ListMenuContextAdicionarExercicio.Name = "ListMenuContextAdicionarExercicio";
            this.ListMenuContextAdicionarExercicio.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextAdicionarExercicio.Text = "Adicionar Exercício";
            this.ListMenuContextAdicionarExercicio.Click += new System.EventHandler(this.ListMenuContextAdicionarExercicio_Click);
            // 
            // ListMenuContextEditarEquacao
            // 
            this.ListMenuContextEditarEquacao.Name = "ListMenuContextEditarEquacao";
            this.ListMenuContextEditarEquacao.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextEditarEquacao.Text = "Editar Equação";
            this.ListMenuContextEditarEquacao.Click += new System.EventHandler(this.MenuEditarEquacao_Click);
            // 
            // ListMenuContextEditarExercicio
            // 
            this.ListMenuContextEditarExercicio.Name = "ListMenuContextEditarExercicio";
            this.ListMenuContextEditarExercicio.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextEditarExercicio.Text = "Editar Exercícios";
            this.ListMenuContextEditarExercicio.Click += new System.EventHandler(this.ListMenuContextEditarExercicios_Click);
            // 
            // ListMenuContextExcluirEquacao
            // 
            this.ListMenuContextExcluirEquacao.Name = "ListMenuContextExcluirEquacao";
            this.ListMenuContextExcluirEquacao.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextExcluirEquacao.Text = "Excluir Equação";
            this.ListMenuContextExcluirEquacao.Click += new System.EventHandler(this.ListMenuContextExcluirEquacao_Click);
            // 
            // ListMenuContextExcluirEquacoes
            // 
            this.ListMenuContextExcluirEquacoes.Name = "ListMenuContextExcluirEquacoes";
            this.ListMenuContextExcluirEquacoes.Size = new System.Drawing.Size(182, 22);
            this.ListMenuContextExcluirEquacoes.Text = "Excluir Equações";
            this.ListMenuContextExcluirEquacoes.Click += new System.EventHandler(this.MenuExcluirEquacoes_Click);
            // 
            // Categoria
            // 
            this.Categoria.BackColor = System.Drawing.Color.Transparent;
            this.Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.ForeColor = System.Drawing.Color.White;
            this.Categoria.Location = new System.Drawing.Point(278, 18);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(130, 23);
            this.Categoria.TabIndex = 4;
            // 
            // EquationBox
            // 
            this.EquationBox.BackColor = System.Drawing.Color.Transparent;
            this.EquationBox.ContextMenuStrip = this.ImageContext;
            this.EquationBox.Location = new System.Drawing.Point(36, 167);
            this.EquationBox.Name = "EquationBox";
            this.EquationBox.Size = new System.Drawing.Size(373, 103);
            this.EquationBox.TabIndex = 3;
            this.EquationBox.TabStop = false;
            // 
            // ImageContext
            // 
            this.ImageContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarImagemToolStripMenuItem});
            this.ImageContext.Name = "ImageContext";
            this.ImageContext.Size = new System.Drawing.Size(165, 26);
            // 
            // exportarImagemToolStripMenuItem
            // 
            this.exportarImagemToolStripMenuItem.Name = "exportarImagemToolStripMenuItem";
            this.exportarImagemToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exportarImagemToolStripMenuItem.Text = "Exportar Imagem";
            this.exportarImagemToolStripMenuItem.Click += new System.EventHandler(this.exportarImagemToolStripMenuItem_Click);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(16, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(256, 23);
            this.Titulo.TabIndex = 2;
            // 
            // BotaoExercicios
            // 
            this.BotaoExercicios.Enabled = false;
            this.BotaoExercicios.Location = new System.Drawing.Point(325, 380);
            this.BotaoExercicios.Name = "BotaoExercicios";
            this.BotaoExercicios.Size = new System.Drawing.Size(75, 23);
            this.BotaoExercicios.TabIndex = 1;
            this.BotaoExercicios.Text = "Exercícios";
            this.BotaoExercicios.UseVisualStyleBackColor = true;
            this.BotaoExercicios.Click += new System.EventHandler(this.BotaoExercicios_Click);
            // 
            // Descricao
            // 
            this.Descricao.BackColor = System.Drawing.Color.Transparent;
            this.Descricao.ContextMenuStrip = this.DescricaoContext;
            this.Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.ForeColor = System.Drawing.SystemColors.Window;
            this.Descricao.Location = new System.Drawing.Point(32, 41);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(376, 123);
            this.Descricao.TabIndex = 0;
            // 
            // DescricaoContext
            // 
            this.DescricaoContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarParaTextoToolStripMenuItem});
            this.DescricaoContext.Name = "DescricaoContext";
            this.DescricaoContext.Size = new System.Drawing.Size(176, 26);
            // 
            // exportarParaTextoToolStripMenuItem
            // 
            this.exportarParaTextoToolStripMenuItem.Name = "exportarParaTextoToolStripMenuItem";
            this.exportarParaTextoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exportarParaTextoToolStripMenuItem.Text = "Exportar para Texto";
            // 
            // ImportEquationsDialog
            // 
            this.ImportEquationsDialog.DefaultExt = "*.xml";
            this.ImportEquationsDialog.FileName = "Equations.xml";
            this.ImportEquationsDialog.Filter = "Equation Files|*.xml|Todos os Arquivos|*.*";
            this.ImportEquationsDialog.Multiselect = true;
            // 
            // SoftEquationHelp
            // 
            this.SoftEquationHelp.HelpNamespace = "SoftEquation.chm";
            // 
            // ExportEquationsDialog
            // 
            this.ExportEquationsDialog.DefaultExt = "*.xml";
            this.ExportEquationsDialog.FileName = "Equations.xml";
            this.ExportEquationsDialog.Filter = "Equation Files|*.xml|Todos os Arquivos|*.*";
            // 
            // ExportImagesDialog
            // 
            this.ExportImagesDialog.Description = "Selecione o diretório para exportar seus arquivos.";
            // 
            // ExportTextDialog
            // 
            this.ExportTextDialog.DefaultExt = "*.doc";
            this.ExportTextDialog.FileName = "Equations.doc";
            this.ExportTextDialog.Filter = "Word Document|*.doc|Todos os Arquivos|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuPrincipal);
            this.HelpButton = true;
            this.SoftEquationHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Form1";
            this.SoftEquationHelp.SetShowHelp(this, true);
            this.Text = "SoftEquation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ListMenuContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquationBox)).EndInit();
            this.ImageContext.ResumeLayout(false);
            this.DescricaoContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuAjuda;
        private System.Windows.Forms.ToolStripMenuItem MenuSobre;
        private System.Windows.Forms.ToolStripTextBox MenuBusca;
        private System.Windows.Forms.ToolStripMenuItem MenuBuscar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView ListMenu;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.ToolStripMenuItem MenuFerramentas;
        private System.Windows.Forms.ToolStripMenuItem MenuSugestoes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem MenuExportarEquacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuExcluirEquacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuImportarEquacoes;
        private System.Windows.Forms.OpenFileDialog ImportEquationsDialog;
        private System.Windows.Forms.Button BotaoExercicios;
        private System.Windows.Forms.ContextMenuStrip ListMenuContext;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextSelecionarCategoria;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextSelecionarTudo;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextAdicionarEquacao;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextEditarEquacao;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextExcluirEquacao;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextExcluirEquacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarEquacao;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox EquationBox;
        private System.Windows.Forms.HelpProvider SoftEquationHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuExportarImagens;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivoAjuda;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextAdicionarExercicio;
        private System.Windows.Forms.ToolStripMenuItem MenuAdicionarExercicio;
        private System.Windows.Forms.SaveFileDialog ExportEquationsDialog;
        private System.Windows.Forms.FolderBrowserDialog ExportImagesDialog;
        private System.Windows.Forms.ToolStripMenuItem MenuEditarExercicio;
        private System.Windows.Forms.ToolStripMenuItem ListMenuContextEditarExercicio;
        private System.Windows.Forms.ContextMenuStrip DescricaoContext;
        private System.Windows.Forms.ToolStripMenuItem exportarParaTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaTextoToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip ImageContext;
        private System.Windows.Forms.ToolStripMenuItem exportarImagemToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog ExportTextDialog;
    }
}

