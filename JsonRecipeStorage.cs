using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace RecipesApp {
  public static class JsonRecipeStorage {
    private static string _filePath = "recipes.json";

    public static List<Recipe> Load() {
      try {
        if (!File.Exists(_filePath)) {
          return new List<Recipe>();
        }

        string json = File.ReadAllText(_filePath);

        if (string.IsNullOrWhiteSpace(json)) {
          return new List<Recipe>();
        }

        // Добавляем обработку ошибок десериализации
        var settings = new JsonSerializerSettings {
          Error = (sender, args) =>
          {
            args.ErrorContext.Handled = true;
            Console.WriteLine($"Ошибка десериализации: {args.ErrorContext.Error.Message}");
          }
        };

        return JsonConvert.DeserializeObject<List<Recipe>>(json, settings) ?? new List<Recipe>();
      }
      catch (Exception ex) {
        Console.WriteLine($"Ошибка при загрузке файла: {ex.Message}");
        return new List<Recipe>();
      }
    }

    public static void Save(List<Recipe> recipes) {
      try {
        string json = JsonConvert.SerializeObject(recipes, Formatting.Indented);
        File.WriteAllText(_filePath, json);
      }
      catch (Exception ex) {
        Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
      }
    }
  }
}