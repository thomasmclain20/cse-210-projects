 using System;
  using System.Collections.Generic;
  using System.IO;

  public class FileManager
  {
      private string fileName = "journal.txt";

      public void SaveEntries(List<Entry> entries, string fileName)
      {
          try
          {
              using (StreamWriter writer = new StreamWriter(fileName))
              {
                  foreach (var entry in entries)
                  {
                      writer.WriteLine($"DATE:{entry.Date}");
                      writer.WriteLine($"TITLE:{entry.Title}");
                      writer.WriteLine($"CONTENT:{entry.Content}");
                      writer.WriteLine("---END ENTRY---");
                  }
              }
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Error saving file: {ex.Message}");
          }
      }

      public List<Entry> LoadEntries(string fileName)
      {
          List<Entry> entries = new List<Entry>();

          try
          {
              if (File.Exists(fileName))
              {
                  string[] lines = File.ReadAllLines(fileName);

                  for(int i = 0; i < lines.Length; i += 4)
                  {
                      if(i + 2 < lines.Length)
                      {
                          string date = lines[i].Replace("DATE:", "");
                          string title = lines[i + 1].Replace("TITLE:", "");
                          string content = lines[i + 2].Replace("CONTENT:", "");

                          Entry entry = new Entry(date, title, content);
                          entry.Date = date;
                          entry.Title = title;
                          entry.Content = content;

                          entries.Add(entry);
                      }
                  }
              }
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Error loading file: {ex.Message}");
          }

          return entries;
      }
  }

