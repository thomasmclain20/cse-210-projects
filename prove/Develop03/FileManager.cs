 using System;
  using System.Collections.Generic;
  using System.IO;

  public class FileManager
  {
      private string fileName = "scriptures.txt";
/* maybe use this later to let people type their own scripture in
      public void SaveScriptures(List<Scripture> scriptures, string fileName)
      {
          try
          {
              using (StreamWriter writer = new StreamWriter(fileName))
              {
                  foreach (var scripture in scriptures)
                  {
                      writer.WriteLine($"REF:{scripture.Reference}");
                      writer.WriteLine($"TEXT:{scripture.Text}");
                      writer.WriteLine("---END SCRIPTURE---");
                  }
              }
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Error saving file: {ex.Message}");
          }
      }
    */



      public List<Scripture> LoadScriptures(string fileName)
      {
          List<Scripture> scriptures = new List<Scripture>();

          try
          {
              if (File.Exists(fileName))
              {
                  string[] lines = File.ReadAllLines(fileName);

                  for(int i = 0; i < lines.Length; i += 3)
                  {
                      if(i + 2 < lines.Length)
                      {
                          string reference = lines[i].Replace("REF:", "");
                          string text = lines[i + 1].Replace("TEXT:", "");

                          Scripture scripture = new Scripture(text, reference);

                          scriptures.Add(scripture);
                      }
                  }
              }
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Error loading file: {ex.Message}");
          }

          return scriptures;
      }
  }

