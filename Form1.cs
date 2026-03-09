using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            lblVersion.Text = Jogo.versao;
        
        }
         
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnListGame_Click(object sender, EventArgs e) {
           string retuned = Jogo.ListarPartidas("T");
            retuned = retuned.Replace("\r", "");

            retuned = retuned.Substring(0, retuned.Length - 1);

            string[] games = retuned.Split('\n');

            for (int i = 0; i < games.Length; i++) {
                listBoxGames.Items.Add(games[i]);
            }

           
           
        }

        private void lblVersion_Click(object sender, EventArgs e) {
            
        }

        private void listBoxGames_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btnCreateGame_Click(object sender, EventArgs e) {
            string nomePartida = txtNameGame.Text;
            string senha = txtPassword.Text;
            string nomeGrupo = txtGroupName.Text;

            
            string idPartida = Jogo.CriarPartida(nomePartida, senha, nomeGrupo);

            textResultGame.Text = "Nome: " + nomePartida + "SENHA: " + senha + "GRUPO: " + nomeGrupo + "ID PARTIDA " + idPartida;

        }
    }
}
