using Newtonsoft.Json;
using Pokedex.Models;
using Pokedex.Properties;
using System;
using System.Configuration;
using System.Globalization;
using System.Linq;
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

            lbl_nomePokemon.Text = "Carregando...";
            img_pokemon.Image = null;

            _cultureInfo = Thread.CurrentThread.CurrentCulture;
            _textInfo = _cultureInfo.TextInfo;
            _lenght = Convert.ToInt32(ConfigurationManager.AppSettings.Get("MaxLengthPokedex"));

            BloquearBotoes();
            Populate();
        }

        private async void Populate()
        {
            try
            {
                var responseList = await ApiPokemon.Instace().GetRequest($"pokemon?limit={_lenght}&offset=0");
                Pokemons = JsonConvert.DeserializeObject<ListPokemon>(responseList);

                await AlternatePokemon(true);

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ChangeImage(Pokemon pokemon)
        {
            try
            {
                if (pokemon.Sprites.FrontDefault != null)
                {
                    img_pokemon.Load(pokemon.Sprites.FrontDefault.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void Btn_proximo_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_nomePokemon.Text = "Carregando...";
                img_pokemon.Image = null;

                BloquearBotoes();

                Index++;

                if (Index >= Pokemons.Results.Count)
                {
                    Index = 0;
                }

                await AlternatePokemon(true);

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_nomePokemon.Text = "Carregando...";
                img_pokemon.Image = null;

                BloquearBotoes();

                Index--;

                if (Index < 0)
                {
                    Index = Convert.ToInt32(Pokemons.Results.Count - 1);
                }

                await AlternatePokemon(true);

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Btn_detalhes_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_nomePokemon.Text = "Carregando...";
                img_pokemon.Image = null;

                BloquearBotoes();

                var pokemon = await AlternatePokemon(false);

                var detalhesPokemon = new DetalhesPokemon(pokemon);

                Hide();
                detalhesPokemon.ShowDialog();
                Show();

                ChangeImage(pokemon);

                lbl_nomePokemon.Text = $"{pokemon.Id} - {_textInfo.ToTitleCase(pokemon.Name)}";

                DesbloquearBotoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_nomePokemon.Text = "Carregando...";
                img_pokemon.Image = null;

                if (txt_buscar.Text != string.Empty)
                {
                    BloquearBotoes();

                    if (txt_buscar.Text == "Trixy_Tracers001")
                    {
                        lbl_nomePokemon.Text = "Trixy_Tracers001";
                        img_pokemon.Image = Resources._001;

                        txt_buscar.Enabled = true;
                        btn_buscar.Enabled = true;
                    }
                    else if (txt_buscar.Text == "Dick_Butt002")
                    {
                        lbl_nomePokemon.Text = "dickbutt";
                        img_pokemon.Image = Resources._002;

                        txt_buscar.Enabled = true;
                        btn_buscar.Enabled = true;
                    }
                    else
                    {
                        var oldIndex = Index;

                        Index = Pokemons.Results.FindIndex(0,
                            Convert.ToInt32(Pokemons.Results.Count),
                            x => x.Name == _textInfo.ToLower(txt_buscar.Text));

                        if (Index != -1)
                        {
                            await AlternatePokemon(true);
                        }
                        else
                        {
                            Index = Convert.ToInt32(txt_buscar.Text) - 1;

                            if (Pokemons.Results.ElementAtOrDefault(Index) != null)
                            {
                                await AlternatePokemon(true);
                            }
                            else
                            {
                                MessageBox.Show("Id/Nome não encontrado", "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                Index = oldIndex;

                                await AlternatePokemon(true);
                            }
                        }

                        DesbloquearBotoes();
                    }
                }
                else
                {
                    MessageBox.Show("Caixa de pesquisa vazia", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    await AlternatePokemon(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Pokemon> AlternatePokemon(bool changeNameImage)
        {
            var basePokemon = await ApiPokemon.Instace().GetRequest(Pokemons.Results[Index].Url.ToString());
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(basePokemon);

            if (changeNameImage == true)
            {
                ChangeImage(pokemon);

                lbl_nomePokemon.Text = $"{pokemon.Id} - {_textInfo.ToTitleCase(pokemon.Name)}";
            }

            return pokemon;
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
