// <auto-generated>
// Code generated by LUISGen homeautomation.json -cs Luis.homeautomation -o 
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Luis
{
    public class homeautomation: Microsoft.Bot.Builder.Core.Extensions.IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            HomeAutomation_TurnOff, 
            HomeAutomation_TurnOn, 
            None
        };
        public Dictionary<Intent, Microsoft.Bot.Builder.Ai.LUIS.IntentData> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] HomeAutomation_Device;
            public string[] HomeAutomation_Operation;
            public string[] HomeAutomation_Room;

            // Instance
            public class _Instance
            {
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] HomeAutomation_Device;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] HomeAutomation_Operation;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] HomeAutomation_Room;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<homeautomation>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }
    }
}
