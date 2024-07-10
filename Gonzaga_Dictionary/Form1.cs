using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Gonzaga_Dictionary
{
    public partial class Form1 : Form
    {
        private string currentWord;
        private JArray wordData;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            currentWord = txtField_searchWord.Text;
            if (string.IsNullOrWhiteSpace(currentWord))
            {
                MessageBox.Show("Please enter a word.");
                return;
            }

            await FetchWordData(currentWord);
            DisplayFullInfo();
        }


        private async Task FetchWordData(string word)
        {
            string apiUrl = $"https://api.dictionaryapi.dev/api/v2/entries/en/{word}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    wordData = JArray.Parse(responseBody);
                }
                catch (HttpRequestException httpRequestException)
                {
                    MessageBox.Show($"Request error: {httpRequestException.Message}");
                }
            }
        }

        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            DisplayFullInfo();
        }

        private void btn_clearResults_Click(object sender, EventArgs e)
        {
            lbl_results.Text = "Results";
            txtField_searchWord.Text = string.Empty;
            txtField_results.Text = string.Empty;
        }

        private void btn_definition_Click(object sender, EventArgs e)
        {
            DisplayDefinitions();
        }

        private void btn_synonyms_Click(object sender, EventArgs e)
        {
            DisplaySynonyms();
        }

        private void btn_usage_Click(object sender, EventArgs e)
        {
            DisplayUsageExamples();
        }

        private void DisplayFullInfo()
        {
            lbl_results.Text = "Results";
            if (wordData == null)
            {
                MessageBox.Show("Please search for a word first.");
                return;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < wordData.Count; i++)
            {
                var wordInfo = (JObject)wordData[i];
                result.AppendLine($"Word: {wordInfo["word"]}");
                var phonetics = wordInfo["phonetics"];
                if (phonetics != null && phonetics.Any())
                {
                    result.AppendLine($"Phonetic: {phonetics[0]["text"]}");
                }

                var meanings = (JArray)wordInfo["meanings"];
                for (int j = 0; j < meanings.Count; j++)
                {
                    var meaning = (JObject)meanings[j];
                    result.AppendLine($"\nPart of Speech: {meaning["partOfSpeech"]}");
                    var definitions = (JArray)meaning["definitions"];
                    int definitionCount = 1;

                    for (int k = 0; k < definitions.Count; k++)
                    {
                        var definition = (JObject)definitions[k];
                        result.AppendLine($"  {definitionCount}. Definition: {definition["definition"]}");
                        var example = definition["example"];
                        if (example != null)
                        {
                            result.AppendLine($"  ● Example: {example}");
                        }
                        else
                        {
                            result.AppendLine($"  ● Example: No example found for this definition");
                        }

                        var synonyms = definition["synonyms"];
                        if (synonyms != null && synonyms.Any())
                        {
                            result.AppendLine($"  ● Synonyms: {string.Join(", ", synonyms)}");
                        }
                        else
                        {
                            result.AppendLine($"  ● Synonyms: No synonym found for this definition");
                        }
                        result.AppendLine("\n");

                        definitionCount++;
                    }

                    var synonymsForMeaning = meaning["synonyms"];
                    if (synonymsForMeaning != null && synonymsForMeaning.Any())
                    {
                        result.AppendLine($"  ● Synonyms for this part of speech: {string.Join(", ", synonymsForMeaning)}");
                    }
                    result.AppendLine("\n");
                }
                result.AppendLine("\n");
            }

            txtField_results.Text = result.ToString();
        }

        private void DisplayDefinitions()
        {
            lbl_results.Text = "Definition";
            if (wordData == null)
            {
                MessageBox.Show("Please search for a word first.");
                return;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < wordData.Count; i++)
            {
                var wordInfo = (JObject)wordData[i];
                result.AppendLine($"Word: {wordInfo["word"]}");
                var phonetic = wordInfo["phonetic"];
                result.AppendLine($"Phonetic: {phonetic}");

                var meanings = (JArray)wordInfo["meanings"];
                for (int j = 0; j < meanings.Count; j++)
                {
                    var meaning = (JObject)meanings[j];
                    result.AppendLine($"\nPart of Speech: {meaning["partOfSpeech"]}");
                    var definitions = (JArray)meaning["definitions"];
                    foreach (var definition in definitions)
                    {
                        result.AppendLine($"  ● {definition["definition"]}");
                    }
                    result.AppendLine("\n");
                }
                result.AppendLine("\n");
            }

            txtField_results.Text = result.ToString();
        }


        private void DisplaySynonyms()
        {
            lbl_results.Text = "Synonyms";
            if (wordData == null)
            {
                MessageBox.Show("Please search for a word first.");
                return;
            }

            StringBuilder result = new StringBuilder();
            bool foundAnySynonyms = false;

            for (int i = 0; i < wordData.Count; i++)
            {
                var wordInfo = (JObject)wordData[i];
                var meanings = (JArray)wordInfo["meanings"];
                foreach (var meaning in meanings)
                {
                    bool foundSynonymsForThisPartOfSpeech = false;
                    var synonymsForMeaning = meaning["synonyms"];
                    if (synonymsForMeaning != null && synonymsForMeaning.Any())
                    {
                        result.AppendLine($"\nPart of Speech: {meaning["partOfSpeech"]}");
                        result.AppendLine($"  ● {string.Join(", ", synonymsForMeaning)}");
                        result.AppendLine("\n");
                        foundSynonymsForThisPartOfSpeech = true;
                        foundAnySynonyms = true;
                    }

                    var definitions = (JArray)meaning["definitions"];
                    foreach (var definition in definitions)
                    {
                        var synonyms = definition["synonyms"];
                        if (synonyms != null && synonyms.Any())
                        {
                            if (!foundSynonymsForThisPartOfSpeech)
                            {
                                result.AppendLine($"\nPart of Speech: {meaning["partOfSpeech"]}");
                                foundSynonymsForThisPartOfSpeech = true;
                            }
                            result.AppendLine($"  ● {string.Join(", ", synonyms)}");
                            foundAnySynonyms = true;
                        }
                    }

                    if (!foundSynonymsForThisPartOfSpeech)
                    {
                        result.AppendLine($"\nPart of Speech: {meaning["partOfSpeech"]}");
                        result.AppendLine("  ● No synonyms found.");
                    }
                    result.AppendLine("\n");
                }
            }

            if (!foundAnySynonyms)
            {
                result.AppendLine("  ● No synonyms found.");
            }

            txtField_results.Text = result.ToString();
        }



        private void DisplayUsageExamples()
        {
            lbl_results.Text = "Usage of word";
            if (wordData == null)
            {
                MessageBox.Show("Please search for a word first.");
                return;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < wordData.Count; i++)
            {
                var wordInfo = (JObject)wordData[i];
                var meanings = (JArray)wordInfo["meanings"];
                foreach (var meaning in meanings)
                {
                    result.AppendLine($"\nPart of Speech: {meaning["partOfSpeech"]}");
                    var definitions = (JArray)meaning["definitions"];
                    bool examplesFound = false;
                    foreach (var definition in definitions)
                    {
                        var example = definition["example"];
                        if (example != null)
                        {
                            examplesFound = true;
                            result.AppendLine($"  ● {example}\n");
                        }
                    }

                    if (!examplesFound)
                    {
                        result.AppendLine("  ● No usage examples found.\n");
                    }
                    result.AppendLine("\n");
                }
            }

            txtField_results.Text = result.ToString();
        }

    }
}
