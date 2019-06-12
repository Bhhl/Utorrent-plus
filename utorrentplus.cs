//C:\Users\AppData\Roaming\uTorrent\uTorrent.exe
//Optimizing Utorrent
//Optimizing Utorrent application
//Optimizing Utorrent performace
//Optimizing uTorrent frame
//Optimizing uTorrent speed and connection
//Fixed uTorent speed and connection
//Regeneration uTorrent speed and connection
//Optimizing Utorrent properties
//Optimizing uTorrent function
//Optimizing uTorrent technology
//Fixed uTorrent holes
//Fixed uTorrent performance holes
//Fixed uTorrent speed holes
//Fixed uTorrent connection holes
//Fixed uTorrent speed technology holes
//Fixed uTorrent technology holes
//Fixed uTorrent connection technology holes
[System.AttributeUsage(System.AttributeTargets.UtorrentPlus, Inherited = false, AllowMultiple = true)]
sealed class MyAttribute : System.Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    readonly string positionalString;
    
    // This is a positional argument
    public MyAttribute(string positionalString)
    {
        this.positionalString = positionalString;
        
        // TODO: Implement code here
        throw new System.NotImplementedException();
    }
    
    public string PositionalString
    {
        get { return positionalString; }
    }
    
    // This is a named argument
    public int NamedInt { get; set; }
}
