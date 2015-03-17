using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XNALevelEditor.Classes.Resource
{
    class Manager
    {
        // Graphic resources
        public List<Classes.Resource.Graphic> GraphicResource = new List<Classes.Resource.Graphic>();

        // Add graphic resource
        public void AddGraphic(string[] FileNames)
        {
            if (FileNames.Length > 0)
            {
                Classes.Resource.Graphic tempGraphic = new Classes.Resource.Graphic();
                List<System.Drawing.Image> tempImage = new List<System.Drawing.Image>();
                tempGraphic.FileNames = new string[FileNames.Length];
                tempGraphic.FilePath = FileNames[0].Substring(0,FileNames[0].LastIndexOf("\\"));
                tempGraphic.Name = "Graphic" + GraphicResource.Count.ToString();
                for (int i = 0; i <= FileNames.Length - 1; i++)
                {
                    tempGraphic.FileNames[i] = FileNames[i].Substring(FileNames[i].LastIndexOf("\\") + 1, FileNames[i].Length - (FileNames[i].LastIndexOf("\\") + 1));
                    tempImage.Add(System.Drawing.Image.FromFile(FileNames[i])); 
                }
                tempGraphic.Images = tempImage;
                tempGraphic.Frames = FileNames.Length;
                GraphicResource.Add(tempGraphic);
            }
            else
            {
                throw new Exception("Invaid file.");
            }
        }

        // Add graphic resource
        public void AddGraphic(Graphic GraphicRes)
        {
            if (GraphicRes != null)
            {
                GraphicResource.Add(GraphicRes);
            }
            else
            {
                throw new Exception("Invalid Object.");
            }
        }

        // Remove graphic resource
        public void RemoveGraphic(int ItemIndex)
        {
            GraphicResource.RemoveAt(ItemIndex);
        }

        // Clear graphic resource
        public void ClearGraphic()
        {
            GraphicResource.Clear();
        }

        // Edit graphic resource
        public void EditGraphic(int ItemIndex, string Name, string[] FileNames, ref List<Classes.Object.GameObject> Objects)
        {
            int FoundItem = -1;
            if (ItemIndex > -1 && Name != "")
            {
                for (int i = 0; i <= Objects.Count - 1; i++)
                {
                    if (Objects[i].GraphicAssetName == GraphicResource[ItemIndex].Name)
                    {
                        FoundItem = i;
                        break;
                    }
                }
                if (FileNames.Length > 0)
                {
                    List<System.Drawing.Image> tempImage = new List<System.Drawing.Image>();
                    GraphicResource[ItemIndex].Images.Clear();
                    GraphicResource[ItemIndex].FileNames = new string[FileNames.Length];
                    for (int i = 0; i <= FileNames.Length - 1; i++)
                    {
                        GraphicResource[ItemIndex].FileNames[i] = FileNames[i].Substring(FileNames[i].LastIndexOf("\\") + 1, FileNames[i].Length - (FileNames[i].LastIndexOf("\\") + 1));
                        tempImage.Add(System.Drawing.Image.FromFile(FileNames[i]));
                    }
                    GraphicResource[ItemIndex].Frames = FileNames.Length; 
                    GraphicResource[ItemIndex].Images = tempImage;
                    if (FoundItem > -1)
                      Objects[FoundItem].Sprite = tempImage;
                }
                if (FoundItem > -1)
                  Objects[FoundItem].GraphicAssetName = Name;
                GraphicResource[ItemIndex].Name = Name;
            }
        }
    }
}
