using System;
using System.IO;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace minTools
{
    public class FolderToolsCollection
    {
        public enum KeywordFilterOptions
        {
            None, Contains, StartsWith
        }
        
        public enum DateModifiedFilterOptions
        {
            None, OnThisDay, BeforeThisDay,OnOrBeforeThisDay,AfterThisDay,OnOrAfterThisDay
        }

        public enum FileSizeFilterOptions
        {
            None, IsExactly, IsMoreThan,IsLessThan,
            IsEqualToOrLessThan,IsEqualToOrMoreThan
        }

        public enum FileSizeSizeOptions
        {
            None, Kb, Mb, Gb
        }

        public class BatchOptions
        {
            public BatchOptions()
            {
                searchLocation = keywords = "";
            }

            public string searchLocation;

            public string keywords;
            public KeywordFilterOptions keywordOptions;

            public DateTime dateModified;
            public DateModifiedFilterOptions dmOptions;

            public double fileSize;
            public FileSizeFilterOptions filterOptions;
            public FileSizeSizeOptions sizeOptions;
        }

        public class BatchRenamer
        {
            public void rename(BatchOptions options)
            {
                //get all files in the folder
                if (options.searchLocation.Trim().Equals(string.Empty))
                    return; //no search location specified
                else if (!Directory.Exists(options.searchLocation))
                    return; //directory no existay

                //get initial search results using keyword and folder, then filter according to BatchOptions
                List<string> filesToRename = getFilesAfterFiltering(options);

                //rename each file in the filtered results
            }

            public List<string> getFilesAfterFiltering(BatchOptions options)
            {
                if (!Directory.Exists(options.searchLocation))
                    return new List<string>();

                List<string> output = new List<string>();

                foreach (string file in Directory.EnumerateFiles(options.searchLocation))
                    if (!doesThisFileFilterOut(options, new FileInfo(file)))
                        output.Add(file);

                return output;
            }

            bool doesThisFileFilterOut(BatchOptions options, FileInfo file)
            {
                double trueSearchFileSizeInBytes = options.fileSize;

                if(options.sizeOptions != FileSizeSizeOptions.None)
                    switch (options.sizeOptions)
                    {
                        case FileSizeSizeOptions.Gb:
                            trueSearchFileSizeInBytes *= 1000000000 ;
                            break;

                        case FileSizeSizeOptions.Mb:
                            trueSearchFileSizeInBytes *= 1000000;
                            break;

                        case FileSizeSizeOptions.Kb:
                            trueSearchFileSizeInBytes *= 1000;
                            break;
                    }

                if (options.sizeOptions != FileSizeSizeOptions.None)
                    switch (options.filterOptions)
                    {
                    case FileSizeFilterOptions.IsEqualToOrLessThan:
                        if (!(file.Length <= trueSearchFileSizeInBytes))
                            return true;    break;

                    case FileSizeFilterOptions.IsEqualToOrMoreThan:
                        if (!(file.Length >= trueSearchFileSizeInBytes))
                            return true; break;

                    case FileSizeFilterOptions.IsExactly:
                        if (!(file.Length == trueSearchFileSizeInBytes))
                            return true; break;

                    case FileSizeFilterOptions.IsLessThan:
                        if (!(file.Length < trueSearchFileSizeInBytes))
                            return true; break;

                    case FileSizeFilterOptions.IsMoreThan:
                        if (!(file.Length > trueSearchFileSizeInBytes))
                            return true; break;
                    }

                if(options.keywordOptions != KeywordFilterOptions.None)
                    switch (options.keywordOptions)
                    {
                        case KeywordFilterOptions.Contains:
                            if(!(file.Name.ToLower().Contains(options.keywords.ToLower())))
                                return true; break;

                            //TODO: complete this, currently uses the Contains block
                        case KeywordFilterOptions.StartsWith:
                            if (!(file.Name.Contains(options.keywords)))
                                return true; break;

                    }

                return false;
            }
        }
    }
}
