using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System_Biblioteca.Models;

namespace System_Biblioteca.Views
{
    /// <summary>
    /// Lógica interna para CadFuncionario.xaml
    /// </summary>
    public partial class CadFuncionario : Window
    {
        private Funcionario _funcionario;
        private int _id;

        public CadFuncionario()
        {
            InitializeComponent();
        }

        public CadFuncionario(int id)
        {
            _id = id;
            InitializeComponent();
            Loaded += CadFuncionario_Loaded;
        }

        private void CadFuncionario_Loaded(object sender, RoutedEventArgs e)
        {
            _funcionario = new Funcionario();
            try
            {
                var dao = new FuncionarioDAO();
                _funcionario = dao.GetById(_id);

                txtNome.Text = _funcionario.NomeFuncionario;
                txtEmail.Text = _funcionario.EmailFuncionario;
                txtCpf.Text = _funcionario.CpfFuncionario;
                txtRg.Text = _funcionario.RgFuncionario;
                txtEndereco.Text = _funcionario.EnderecoFuncionario;
                txtTelefone.Text = _funcionario.TelefoneFuncionario;
                cmbTurnoFuncionario.Text = _funcionario.Turno;
                if (_funcionario.SexoFuncionario == "Feminino")
                {
                    rdbtFeminino.IsChecked = true;
                }
                else
                {
                    rdbtMasculino.IsChecked = true;
                }
                dtpDataNascFuncionario.SelectedDate = _funcionario.DataNascimentoFuncionario;
            }
            catch
            {
                throw new Exception("Nenhum registro foi encontrado");
            }
        }

        //private void SalvarDadosFunc()
        //{
        //    try
        //    {
        //        var dao = new FuncionarioDAO();
        //        if(_funcionario.Id == 0)
        //        {
        //            dao.Insert(_funcionario);
        //        }
        //        else
        //        {
        //            dao.Update(_funcionario);
        //        }
        //    }
        //    catch 
        //    {
        //        throw new Exception("Não executado");
        //    }
        //}

        private void btnSalvarFun_Click(object sender, RoutedEventArgs e)
        {
            _funcionario.NomeFuncionario = txtNome.Text;
            _funcionario.EmailFuncionario = txtEmail.Text;
            _funcionario.CpfFuncionario = txtCpf.Text;
            _funcionario.RgFuncionario = txtRg.Text;
            _funcionario.EnderecoFuncionario = txtEndereco.Text;
            _funcionario.TelefoneFuncionario = txtTelefone.Text;
            _funcionario.Turno = cmbTurnoFuncionario.Text;
            if (rdbtFeminino.IsChecked == true)
            {
                _funcionario.SexoFuncionario = "Feminino";

            }
            else
            {
                _funcionario.SexoFuncionario = "Masculino";
            }
            _funcionario.DataNascimentoFuncionario = dtpDataNascFuncionario.SelectedDate;

            try
            {
                var dao = new FuncionarioDAO();
                if (_funcionario.Id == 0)
                {
                    dao.Insert(_funcionario);
                }
                else
                {
                    dao.Update(_funcionario);
                }
                MessageBox.Show("Registro Salvo com Sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!!!!!!!!!!!!" + ex.Message);
            }
        }

        private void btnInserirImg_Click(object sender, RoutedEventArgs e)
        {
            //var dao = new FuncionarioDAO();
            string saida = Directory.GetCurrentDirectory();
            string imgOriginal = saida.Substring(0, saida.Length - 9) + @"Imagens/avatar.jpg";
            // saida = saida.Substring(0, saida.Length - 9) + @"Funcionarios/" + VrsGlobais.nomeLogado + "/";

            string sourcePath = "", fileName = "";

            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == true)
            {
                sourcePath = opf.FileName;
                fileName = opf.SafeFileName;

                if (sourcePath != "")
                {

                }
            }
        }

        private void btnSalvarFun_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
