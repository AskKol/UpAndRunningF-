open System.Windows.Forms

//let webClient = new System.Net.WebClient()
//let webContent= webClient.DownloadString("http://fsharp.org")
//let aForm= new Form()
//aForm.Text <- "Hello from F#"
//aForm.Height <- 600
//aForm.Width <- 600

////This is another way of setting mutable properties
////let aFormII = new Form(Text="Hello from f",Height=600, Width=600)

//let aWebBrowser = new WebBrowser(ScriptErrorsSuppressed=true, Dock=DockStyle.Fill, DocumentText=webContent)
//aForm.Controls.Add(aWebBrowser)
//aForm.Show()


//let webContent2=
//    let webClient =new System.Net.WebClient()
//    webClient.DownloadString("http://fsharp.org")

//let DisplayForm = 
//    let aForm2 = new Form(Text="Hello from f",Height=600, Width=600)
//    let webBrowser=new WebBrowser(ScriptErrorsSuppressed=true, Dock=DockStyle.Fill, DocumentText=webContent2)
//    aForm2.Controls.Add(webBrowser)
//    aForm2.Show()



let GetUrlConetent (url:string) =
    let webClient =new System.Net.WebClient()
    webClient.DownloadString(url)


let DisplayAForm (aText:string,aHeight:int, aWidth:int,content:string) = 
    use aForm2 = new Form(Text=aText,Height=aHeight, Width=aWidth)
    let webBrowser=new WebBrowser(ScriptErrorsSuppressed=true, Dock=DockStyle.Fill, DocumentText=content)
    aForm2.Controls.Add(webBrowser)
    aForm2.Show()

let ShowWebContentOfUrl (url:string) =
    DisplayAForm("WorkingWithF#", 550,550, GetUrlConetent(url))