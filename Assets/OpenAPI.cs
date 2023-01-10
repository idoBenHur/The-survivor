using OpenAI_API;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class OpenAPI : MonoBehaviour
{
    private void Start()
    {
        var task = StartAsync();
    }

    // Start is called before the first frame update
    async Task StartAsync()
    {
        Debug.Log("running..");

        var apikey = "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";

        try
        {
            var api = new OpenAI_API.OpenAIAPI(apikey, "text-davinci-003");
            var result = await api.Completions.CreateCompletionAsync(
                "This is a list of scenarios and possible concise actions to take based on them: " +
                "1. scenario: locked in a basement. actions: break the window//drill a hole. " +
                "2. scenario: freezing in Siberia. actions: hitchhike south//ask a local to get in. " +
                "3. scenario: alone in the world after surviving a nuclear apocalypse, trying to avoid radiation. actions: find a fridge to hide in//commit suicide. " +
                "4. scenario: dying of thirst in the Sahara. Actions: ", temperature: 0.8);
            //var result = await api.Completions.CreateCompletionAsync("Lorem ipsum dolor sit amet,", temperature: 0.1);
            //var result = await api.Completions.CreateCompletionAsync("o be, or not to be:", temperature: 0.1);
            //var result = await api.Completions.CreateCompletionAsync("if (Physics.Raycast(transform.position,", temperature: 0.1);
            //var result = await api.Completions.CreateCompletionAsync("Once upon a time ", temperature: 0.1);
            //var result = await api.Completions.CreateCompletionAsync("3.14159265359", temperature: 0.1);

            //var result = await api.Search.GetBestMatchAsync("Washington DC", "Canada", "China", "USA", "Spain");
            //var result = await api.Search.GetBestMatchAsync("RaycastHit", "Unity3D", "Godot", "Unreal Engine", "GameMaker");
            //Console.WriteLine(result.ToString());
            Debug.Log("result=" + result.ToString());
        }
        catch (System.Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
}
