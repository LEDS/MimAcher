﻿using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using MimAcher.Entidades;
using System;
using Android.Views;
using System.Threading.Tasks;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.Support.V7.App;

namespace MimAcher.Activities
{
    [Activity(Label = "MimAcher", Theme = "@style/Theme.Splash")]
    public class MainActivity : Activity
    {
        
        //Variaveis globais
        //até comunicar com o banco informações hipotéticas
        private readonly string _campus = "Serra";
        private readonly string _senha = null;
        private string _nome = "Gustavo";
        private readonly string _email = null;
        private readonly string _nascimento = "09/10/1995";
        private readonly string _telefone = "00000000";
        private string _userEmail;
        private string _userPassword;


        private static readonly TaskScheduler UiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

        //Metodos do controlador
        //Cria e controla a activity
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            //Exibindo o layout .axml
            SetContentView(Resource.Layout.Main);

            //Iniciando as variaveis do contexto
            var campoEmail = FindViewById<EditText>(Resource.Id.email);
            var campoSenha = FindViewById<EditText>(Resource.Id.senha);
            var entrar = FindViewById<Button>(Resource.Id.entrar);
            var inscrevase = FindViewById<Button>(Resource.Id.inscrevase);

            //Funcionalidades
            //Resgatando o que foi digitado nos EditText
            campoEmail.TextChanged += (sender, e) => _userEmail = e.Text.ToString();
            campoSenha.TextChanged += (sender, p) => _userPassword = p.Text.ToString();

            
            //Login button click action, e passando o _nome do usuário para próxima activity
            entrar.Click += delegate
            {
                ValidaLogin(_userEmail, _userPassword);
                var participante = new Participante(MontarUsuário());
                var resultadoActivity = new Intent(this, typeof(ResultadoActivity));
                resultadoActivity.PutExtra("member", participante.ParticipanteToBundle());
                StartActivity(resultadoActivity);
            };

            //Tenho que fazer a autenticação no banco de dados
            //Ideia é buscar usuario no banco, se existir retorna true e checa senha, se nao retorna usuario inexistente
            //Busca senha neste mesmo usuario, se for igual retorna true se nao retorna senha invalida

            inscrevase.Click += delegate {
                StartActivity(typeof(InscreverActivity));
            };


        }

        


        private static bool ValidaLogin(string email, string senha)
        {
            bool check;
            if (true)
            {
                check = true;
            }

            return check;
        }

        //função temporaria
        //deve pegar o usuario no banco
        private Dictionary<string, string> MontarUsuário()
        {
            var informacoes = new Dictionary<string, string>
            {
                ["campus"] = _campus,
                ["senha"] = _senha,
                ["email"] = _email,
                ["nome"] = _nome,
                ["telefone"] = _telefone,
                ["nascimento"] = _nascimento
            };

            return informacoes;
        }


        public void OnClick(View v)
        {
            throw new NotImplementedException();
        }

        public void OnConnected(Bundle connectionHint)
        {
            throw new NotImplementedException();
        }

        public void OnConnectionSuspended(int cause)
        {
            throw new NotImplementedException();
        }

        public void OnConnectionFailed(ConnectionResult result)
        {
            throw new NotImplementedException();
        }
    }
}
