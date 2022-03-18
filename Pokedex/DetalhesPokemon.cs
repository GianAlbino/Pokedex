using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class DetalhesPokemon : Form
    {
        private readonly Pokemon _pokemon;
        private readonly CultureInfo _cultureInfo;
        private readonly TextInfo _textInfo;
        private readonly List<Uri> _spritesUri = new List<Uri>();

        private int indexForm = 0;

        public DetalhesPokemon(Pokemon pokemon)
        {
            InitializeComponent();

            try
            {
                _cultureInfo = Thread.CurrentThread.CurrentCulture;
                _textInfo = _cultureInfo.TextInfo;

                _pokemon = pokemon;
                _pokemon.Name = _textInfo.ToTitleCase(_pokemon.Name);

                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private void Btn_tipo_Click(object sender, EventArgs e)
        {
            BloquearBotoes();

            try
            {
                txtbox_detalhes.AppendText($"Tipagem do {_pokemon.Name}\r\n");
                txtbox_detalhes.AppendText($"{_pokemon.Types[0].Type.Name}\r\n");

                if (_pokemon.Types.ElementAtOrDefault(1) != null)
                {
                    txtbox_detalhes.AppendText($"{_pokemon.Types[1].Type.Name}\r\n");
                }

                txtbox_detalhes.AppendText("\r\n");

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private void Btn_status_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();
                txtbox_detalhes.AppendText($"Status do {_pokemon.Name}\r\n");
                txtbox_detalhes.AppendText($"HP: {_pokemon.Stats[0].BaseStat}\r\n");
                txtbox_detalhes.AppendText($"Attack: {_pokemon.Stats[1].BaseStat}\r\n");
                txtbox_detalhes.AppendText($"Defense: {_pokemon.Stats[2].BaseStat}\r\n");
                txtbox_detalhes.AppendText($"Sp. Atk: {_pokemon.Stats[3].BaseStat}\r\n");
                txtbox_detalhes.AppendText($"Sp. Def: {_pokemon.Stats[4].BaseStat}\r\n");
                txtbox_detalhes.AppendText($"Speed: {_pokemon.Stats[5].BaseStat}\r\n\r\n");

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private void Btn_movimentos_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();

                txtbox_detalhes.AppendText($"Movimentos do {_pokemon.Name}\r\n");

                foreach (var move in _pokemon.Moves)
                {
                    txtbox_detalhes.AppendText($"{move.MoveMove.Name}\r\n");
                }

                txtbox_detalhes.AppendText("\r\n");

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private async void Btn_fraquezas_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();

                txtbox_detalhes.AppendText($"Fraquezas do {_pokemon.Name}\r\n");
                var response = await ApiPokemon.Instace().GetRequest($"{_pokemon.Types[0].Type.Url}");

                List<TypePokemon> typesPokemon = new List<TypePokemon>
                {
                    JsonConvert.DeserializeObject<TypePokemon>(response)
                };

                if (_pokemon.Types.ElementAtOrDefault(1) != null)
                {
                    response = await ApiPokemon.Instace().GetRequest($"{_pokemon.Types[1].Type.Url}");
                    typesPokemon.Add(JsonConvert.DeserializeObject<TypePokemon>(response));
                }

                foreach (var type in typesPokemon)
                {
                    txtbox_detalhes.AppendText($"Fraquezas do tipo {type.Name}\r\n");

                    foreach (var damage in type.DamageRelations.DoubleDamageFrom)
                    {
                        txtbox_detalhes.AppendText($"2X do tipo {damage.Name}\r\n");
                    }

                    foreach (var damage in type.DamageRelations.HalfDamageFrom)
                    {
                        txtbox_detalhes.AppendText($"0.5X do tipo {damage.Name}\r\n");
                    }

                    foreach (var damage in type.DamageRelations.NoDamageFrom)
                    {
                        txtbox_detalhes.AppendText($"0X do tipo {damage.Name}\r\n");
                    }

                    txtbox_detalhes.AppendText("\r\n");
                }

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private async void Btn_localizacao_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();

                txtbox_detalhes.AppendText($"Localização do {_pokemon.Name}\r\n");
                var response = await ApiPokemon.Instace().GetRequest(_pokemon.LocationAreaEncounters.ToString());
                List<Locations> locations = JsonConvert.DeserializeObject<List<Locations>>(response);

                foreach (var location in locations)
                {
                    txtbox_detalhes.AppendText($"{location.LocationArea.Name}\r\n");
                }

                txtbox_detalhes.AppendText("\r\n");

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private void Btn_habilidades_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();

                txtbox_detalhes.AppendText($"Habilidades do {_pokemon.Name}\r\n");

                foreach (var ability in _pokemon.Abilities)
                {
                    txtbox_detalhes.AppendText($"{ability.AbilityAbility.Name}\r\n");
                }

                txtbox_detalhes.AppendText("\r\n");

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private async void Btn_vantagem_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();

                txtbox_detalhes.AppendText($"Vantagens do {_pokemon.Name}\r\n");
                var response = await ApiPokemon.Instace().GetRequest($"{_pokemon.Types[0].Type.Url}");

                List<TypePokemon> typesPokemon = new List<TypePokemon>
                {
                    JsonConvert.DeserializeObject<TypePokemon>(response)
                };

                if (_pokemon.Types.ElementAtOrDefault(1) != null)
                {
                    response = await ApiPokemon.Instace().GetRequest($"{_pokemon.Types[1].Type.Url}");
                    typesPokemon.Add(JsonConvert.DeserializeObject<TypePokemon>(response));
                }

                foreach (var type in typesPokemon)
                {
                    txtbox_detalhes.AppendText($"Vantagens do tipo {type.Name}\r\n");

                    foreach (var damage in type.DamageRelations.DoubleDamageTo)
                    {
                        txtbox_detalhes.AppendText($"2X do tipo {damage.Name}\r\n");
                    }

                    foreach (var damage in type.DamageRelations.HalfDamageTo)
                    {
                        txtbox_detalhes.AppendText($"0.5X do tipo {damage.Name}\r\n");
                    }

                    foreach (var damage in type.DamageRelations.NoDamageTo)
                    {
                        txtbox_detalhes.AppendText($"0X do tipo {damage.Name}\r\n");
                    }

                    txtbox_detalhes.AppendText("\r\n");
                }

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private void Btn_altura_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();

                txtbox_detalhes.AppendText($"Altura do {_pokemon.Name}\r\n");
                txtbox_detalhes.AppendText($"{_pokemon.Height} dm\r\n");

                txtbox_detalhes.AppendText("\r\n");

                txtbox_detalhes.AppendText($"Peso do {_pokemon.Name}\r\n");
                txtbox_detalhes.AppendText($"{_pokemon.Weight} hg\r\n");

                txtbox_detalhes.AppendText("\r\n");

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                BloquearBotoes();

                txtbox_detalhes.Clear();

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DesbloquearBotoes();
            }
        }

        private void Populate()
        {
            _pokemon.Name = RepairNames.Instance().Repair(_pokemon.Name);

            if (_pokemon.Sprites.FrontDefault != null)
            {
                _spritesUri.Add(_pokemon.Sprites.FrontDefault);
                ChangeForm(_pokemon.Sprites.FrontDefault);
            }
            if (_pokemon.Sprites.FrontFemale != null)
            {
                _spritesUri.Add(_pokemon.Sprites.FrontFemale);
            }
            if (_pokemon.Sprites.FrontShiny != null)
            {
                _spritesUri.Add(_pokemon.Sprites.FrontShiny);
            }
            if (_pokemon.Sprites.FrontShinyFemale != null)
            {
                _spritesUri.Add(_pokemon.Sprites.FrontShinyFemale);
            }

            lbl_nomePokemon.Text = $"{_pokemon.Id} - {_textInfo.ToTitleCase(_pokemon.Name)}";
        }

        private void BloquearBotoes()
        {
            btn_vantagem.Enabled = false;
            btn_fraquezas.Enabled = false;
            btn_habilidades.Enabled = false;
            btn_localizacao.Enabled = false;
            btn_movimentos.Enabled = false;
            btn_peso.Enabled = false;
            btn_status.Enabled = false;
            btn_tipo.Enabled = false;
            btn_limpar.Enabled = false;
        }

        private void DesbloquearBotoes()
        {
            btn_vantagem.Enabled = true;
            btn_fraquezas.Enabled = true;
            btn_habilidades.Enabled = true;
            btn_localizacao.Enabled = true;
            btn_movimentos.Enabled = true;
            btn_peso.Enabled = true;
            btn_status.Enabled = true;
            btn_tipo.Enabled = true;
            btn_limpar.Enabled = true;
        }

        private void Btn_proximoForm_Click(object sender, EventArgs e)
        {
            indexForm++;

            if (_spritesUri.ElementAtOrDefault(indexForm) != null)
            {
                ChangeForm(_spritesUri[indexForm]);
            }
            else if (indexForm > _spritesUri.Count - 1)
            {
                indexForm = 0;
                ChangeForm(_spritesUri[indexForm]);
            }
        }

        private void Btn_anteriorForm_Click(object sender, EventArgs e)
        {
            indexForm--;

            if (_spritesUri.ElementAtOrDefault(indexForm) != null)
            {
                ChangeForm(_spritesUri[indexForm]);
            }
            else if (indexForm < 0)
            {
                indexForm = _spritesUri.Count - 1;
                ChangeForm(_spritesUri[indexForm]);
            }
        }

        private void ChangeForm(Uri sprite)
        {
            if (sprite != null)
            {
                img_pokemon.Load(sprite.ToString());
            }
        }
    }
}
