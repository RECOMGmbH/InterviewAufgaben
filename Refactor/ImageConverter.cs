using System;

namespace Refactor
{
  /*
    Gegeben ist dieser Image-Konverter, der eines der Formate ImageTypes in Bmp umwandeln kann.
    
    Die Benutzung ist so gedacht:
    
    var ic = new ImageConverter(ImageTypes.Gif);
    var bmpAsByteArray = ic.ToBmp(imageDataAsRawByteArray);
        
     
    Welche Probleme ergeben sich hinsichtlich, der Wiederverwandbarkeit, Wartung und Erweiterbarkeit?
    Wie könnte ein Refactoring aussehen?
  */
      
    public enum ImageTypes
    {
      Png,
      Jpeg,
      Gif,
      Bmp,
      Svg,
    }

    public class ImageConverter
    {
        private readonly ImageTypes _type;

        public ImageConverter(ImageTypes type)
        {
            _type = type;
        }

        public byte[] ToBmp(byte[] rawData)
        {
            switch (_type)
            {
                case ImageTypes.Bmp:
                    return rawData; 
                case ImageTypes.Gif:
                    return ConvertFromGif(rawData);
                case ImageTypes.Png:
                    return ConvertFromPng(rawData);
                case ImageTypes.Jpeg:
                    return ConvertFromJpeg(rawData);
                case ImageTypes.Svg:
                    return ConvertFromSvg(rawData);
                default:
                    throw new NotImplementedException();
            }
        }

        private byte[] ConvertFromSvg(byte[] content)
        {
            // Do some conversion
            // return Converted Image as byte[]
            return null;  
        }

        private byte[] ConvertFromJpeg(byte[] content)
        {
            // Do some conversion
            // return Converted Image as byte[]
            return null;  
        }

        private byte[] ConvertFromPng(byte[] content)
        {
            // Do some conversion
            // return Converted Image as byte[]
            return null;  
        }

        private byte[] ConvertFromGif(byte[] content)
        {
            // Do some conversion
            // return Converted Image as byte[]
            return null;  
        }
    }
}