using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Download
{
    public bool finished;
    public string name;
}

class UnfinishedDownloads
{
    public string[] unfinished(Dictionary<string, Download> downloads)
    {
        return downloads.Values
            .Where(download => download.finished == false)
            .Select(download => download.name)
            .ToArray();
    }
}