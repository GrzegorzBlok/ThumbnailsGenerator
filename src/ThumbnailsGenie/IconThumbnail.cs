﻿using System;
using MimeTypes;

namespace ThumbnailsGenie
{
    public class IconThumbnail
    {
        private readonly Icons iconsStorage = new Icons();

        public byte[] GetThumbnailForMimeType(string mimeType, Thumbnails.Size pxSize = Thumbnails.Size.Px32)
        {
            try
            {
                var extension = MimeTypeMap.GetExtension(mimeType).Replace(".", "");
 
                return iconsStorage.GetIcon(extension, pxSize);
            }
            catch (Exception)
            {
                return iconsStorage.GetIcon("_blank", pxSize);
            }    
        }

        public byte[] GetThumbnailForExtension(string extension, Thumbnails.Size pxSize = Thumbnails.Size.Px32)
        {
            try
            {
                return iconsStorage.GetIcon(extension, pxSize);
            }
            catch (Exception)
            {
                return iconsStorage.GetIcon("_blank", pxSize);
            }
        }
    }
}
