using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace MnistDataParser
{
    public class Parser
    {
        public List<Record> Parse(string imagesFile, string labelsFile)
        {
            var records = new List<Record>();

            using (var imagesFileReader = new BinaryReader(File.Open(imagesFile, FileMode.Open)))
            using (var labelsFileReader = new BinaryReader(File.Open(labelsFile, FileMode.Open)))
            {
                imagesFileReader.ReadInt32();
                int images = ReadBigEndianInt32(imagesFileReader);
                int columns = ReadBigEndianInt32(imagesFileReader);
                int rows = ReadBigEndianInt32(imagesFileReader);
                int imageSize = columns*rows;

                labelsFileReader.ReadInt32();
                int labels = ReadBigEndianInt32(labelsFileReader);
                
                Debug.Assert(images == labels);
                
                for (int i = 0; i < images; i++)
                {
                    var record = new Record
                    {
                        Image = imagesFileReader.ReadBytes(imageSize),
                        Label = labelsFileReader.ReadByte()
                    };
                    records.Add(record);
                }

                return records;
            }
        }

        private int ReadBigEndianInt32(BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(4);
            return ((bytes[3] | (bytes[2] << 8)) | (bytes[1] << 0x10)) | (bytes[0] << 0x18);
        }
    }
}
