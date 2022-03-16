﻿using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Pokedex : Form
    {
        private ListPokemon Pokemons = new ListPokemon();
        private int Index = 0;

        private readonly CultureInfo _cultureInfo;
        private readonly TextInfo _textInfo;
        private readonly int _lenght;

        public Pokedex()
        {
            InitializeComponent();

            _cultureInfo = Thread.CurrentThread.CurrentCulture;
            _textInfo = _cultureInfo.TextInfo;
            _lenght = Convert.ToInt32(ConfigurationManager.AppSettings.Get("MaxLengthPokedex"));

            BloquearBotoes();
            Populate();
        }

        private async void Populate()
        {
            var responseList = await ApiPokemon.Instace().GetRequest($"pokemon?limit={_lenght}&offset=0"); ;
            Pokemons = JsonConvert.DeserializeObject<ListPokemon>(responseList);

            var responsePokemon = await ApiPokemon.Instace().GetRequest(Pokemons.Results[Index].Url.ToString());
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responsePokemon);

            ChangeImage(pokemon);

            lbl_nomePokemon.Text = $"{pokemon.Id} - {_textInfo.ToTitleCase(pokemon.Name)}";

            DesbloquearBotoes();
        }

        private void ChangeImage(Pokemon pokemon)
        {
            if (pokemon.Sprites.FrontDefault != null)
            {
                img_pokemon.Load(pokemon.Sprites.FrontDefault.ToString());
            }
        }

        private async void Btn_proximo_Click(object sender, EventArgs e)
        {
            BloquearBotoes();

            Index++;

            if (Index >= Pokemons.Results.Count)
            {
                Index = 0;
            }

            var responsePokemon = await ApiPokemon.Instace().GetRequest(Pokemons.Results[Index].Url.ToString());
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responsePokemon);

            ChangeImage(pokemon);

            lbl_nomePokemon.Text = $"{pokemon.Id} - {_textInfo.ToTitleCase(pokemon.Name)}";

            DesbloquearBotoes();
        }

        private async void Btn_anterior_Click(object sender, EventArgs e)
        {
            BloquearBotoes();

            Index--;

            if (Index < 0)
            {
                Index = Convert.ToInt32(Pokemons.Results.Count - 1);
            }

            var responsePokemon = await ApiPokemon.Instace().GetRequest(Pokemons.Results[Index].Url.ToString());
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responsePokemon);

            ChangeImage(pokemon);

            lbl_nomePokemon.Text = $"{pokemon.Id} - {_textInfo.ToTitleCase(pokemon.Name)}";

            DesbloquearBotoes();
        }

        private async void Btn_detalhes_Click(object sender, EventArgs e)
        {
            BloquearBotoes();

            var response = await ApiPokemon.Instace().GetRequest(Pokemons.Results[Index].Url.ToString());
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(response);

            var detalhesPokemon = new DetalhesPokemon(pokemon);
            detalhesPokemon.ShowDialog();

            DesbloquearBotoes();
        }

        private async void Btn_buscar_Click(object sender, EventArgs e)
        {
            BloquearBotoes();

            var oldIndex = Index;

            Index = Pokemons.Results.FindIndex(0,
                Convert.ToInt32(Pokemons.Results.Count),
                x => x.Name == _textInfo.ToLower(txt_buscar.Text));

            if(Index != -1)
            {
                var responsePokemon = await ApiPokemon.Instace().GetRequest(Pokemons.Results[Index].Url.ToString());
                Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responsePokemon);

                ChangeImage(pokemon);

                lbl_nomePokemon.Text = $"{pokemon.Id} - {_textInfo.ToTitleCase(pokemon.Name)}";
            }
            else
            {
                Index = oldIndex;
            }

            DesbloquearBotoes();
        }

        private void BloquearBotoes()
        {
            btn_anterior.Enabled = false;
            btn_proximo.Enabled = false;
            btn_detalhes.Enabled = false;
            txt_buscar.Enabled = false;
            btn_buscar.Enabled = false;
        }

        private void DesbloquearBotoes()
        {
            txt_buscar.Enabled = true;
            btn_buscar.Enabled = true;
            btn_anterior.Enabled = true;
            btn_proximo.Enabled = true;
            btn_detalhes.Enabled = true;
            txt_buscar.Clear();
        }
    }
}
