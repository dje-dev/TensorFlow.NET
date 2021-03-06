﻿using System;
using static Tensorflow.Binding;

namespace Tensorflow.Keras
{
    public partial class Preprocessing
    {
        public static string[] WHITELIST_FORMATS = new[] { ".bmp", ".gif", ".jpeg", ".jpg", ".png" };

        /// <summary>
        /// Generates a `tf.data.Dataset` from image files in a directory.
        /// https://www.tensorflow.org/api_docs/python/tf/keras/preprocessing/image_dataset_from_directory
        /// </summary>
        /// <param name="directory">Directory where the data is located.</param>
        /// <param name="labels"></param>
        /// <param name="label_mode"></param>
        /// <param name="class_names"></param>
        /// <param name="color_mode"></param>
        /// <param name="batch_size"></param>
        /// <param name="image_size"></param>
        /// <param name="shuffle"></param>
        /// <param name="seed"></param>
        /// <param name="validation_split"></param>
        /// <param name="subset"></param>
        /// <param name="interpolation"></param>
        /// <param name="follow_links"></param>
        /// <returns></returns>
        public Tensor image_dataset_from_directory(string directory,
            string labels = "inferred",
            string label_mode = "int",
            string class_names = null,
            string color_mode = "rgb",
            int batch_size = 32,
            TensorShape image_size = null,
            bool shuffle = true,
            int? seed = null,
            float validation_split = 0.2f,
            string subset = null,
            string interpolation = "bilinear",
            bool follow_links = false)
        {
            int num_channels = 0;
            if (color_mode == "rgb")
                num_channels = 3;
            // C:/Users/haipi/.keras/datasets/flower_photos
            var (image_paths, label_list, class_name_list) = tf.keras.preprocessing.dataset_utils.index_directory(directory,
                labels,
                WHITELIST_FORMATS,
                class_names: class_names,
                shuffle: shuffle,
                seed: seed,
                follow_links: follow_links);

            throw new NotImplementedException("");
        }
    }
}
