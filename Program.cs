using System;
using System.Net;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Net.NetworkInformation;
using System.IO;

namespace Pinger
{
    class Program
    {
        static void Main(string[] args)
        {   
            Start:
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                 ``.....```                                        ``.....``");
            Console.WriteLine("                            `.---.......---:-.`                             ``.-:--.......--:.`");
            Console.WriteLine("                          `-:.      `````   `-:/-.                       `.---.   `````      .-:.");
            Console.WriteLine("                         .:.          `.-/+syso//:-`                    `...:+sso+:.`          `:-`");
            Console.WriteLine("                       `-:`                  .+ymds:.                   .-//:.`                  --`");
            Console.WriteLine("                       .:`   `...``             `:oo:`                `-:-`              `````    --`");
            Console.WriteLine("                       ..-ohNNMMNNNmdyo/.          `-:.`            `--`          `:+ydmNmhs/:::-.`.`");
            Console.WriteLine("                        `.:ohdNNNNNMMMMMNms:`        `--           .-`         -odNMMMMMNms/.    ``");
            Console.WriteLine("                          `.:+yhdmddddNMMMMMNs-     /:::`          ...:`    .omMMMMMNmdddy+-`");
            Console.WriteLine("                            `.:+ydmNNNMMMMMMMMNd/   :y+-            `::   -yNMMMMMMMMMNNms/.");
            Console.WriteLine("                              `.+ymNNmddNMNMMMMMMd/  //.            .:  -hNMMMMMNMNddmmNmy/.");
            Console.WriteLine("                              .-::-:/+++hN+///oymMMh-`/-           `/``yNMNhs+///mmo++/:--:-`");
            Console.WriteLine("                            `-:`.ohyo/:-...-://:--omNo:+.`       `./+/mNy:-////--..-:/oshs:`--`    ```");
            Console.WriteLine("                     `...``-:.`+o-`            `.:`.dNmd-:`     `--ymNN- --`            `.+o``:-.`.-.-`");
            Console.WriteLine("                     .:/---.` +y-`              `.  oMMm./.     `:-hMMh  .`              `-oy  .---+o/.");
            Console.WriteLine("                    `-/+:.----`-/ooo+++/++/++++/:.:sNMMd +-.```../.oMMMh/.:/++++/++/++++oo+:``...`-/+:.");
            Console.WriteLine("                   `.:+smNNNNNms/-......+y..-:/ohmNMMMMo hyso+osyh.:MMMMNmy/-....oo........-://::::--..`");
            Console.WriteLine("                   ``:+yhhysssso+/:::::---.-:+ymNNMMMMN. NMNmhdNNN- dMMNdy+:-.....--:---..```      `..``");
            Console.WriteLine("                     `..--....```            .:+symNMM+  NMMmddMMM- -mmy+-`");
            Console.WriteLine("                                               `-/sdmo   NMMmddMMM:  -s/.");
            Console.WriteLine("                                                 `:o/   `MMMmddMMM/   .:.`");
            Console.WriteLine("                                                `.:.`/: .MMMmddMMM+ ./``:-`");
            Console.WriteLine("                                               `--`/dNs :MMMmddMMMs :Mm+..:.`");
            Console.WriteLine("                                         `.-.-//.:hNMM/ sMMNmmmNMMd .MMMm+.::-..-`");
            Console.WriteLine("                    `.`--```       ```.---.``od-sNMMMM- dMMNdddmMMN.`NMMMMh.ys. `---.```         `.-`.`");
            Console.WriteLine("                    `--`.:://////:::--...:+ymMM+NMMMMM: NMMMNmmNMMM:`NMMMMM+NMmh+:-..--------------`.:`");
            Console.WriteLine("                     .:`  -+-```-//+oshmmNMMMMMmmMMdhmh.+dNMMMMMNds.omdhNMNdMMMMMNNmdyo+//:```.//   :-");
            Console.WriteLine("                      -:  `hm-  .sNMMMMMMMMMMMMMMMMy/:oms//:///://ody::oMMMMMMMMMMMMMMMMMh-  .hm.  --`");
            Console.WriteLine("                      `--  .dN+   :dMMMMMMMMMMMMMMMMMNh+/syyyyysys+/yNNMMMMMMMMMMMMMMMMN+`  -mN:  -:`");
            Console.WriteLine("                       `:-  -mMs`  `oNMMMMMMMMMMMMMMNs.    `````    `+mMMMMMMMMMMMMMMMy.   +NN/  .:`");
            Console.WriteLine("                        `:-  -mMh.   -hMMMMMMMMMNNmy:      `oys.      .sdNNMMMMMMMMMd/   `sMN/  .:.");
            Console.WriteLine("                         `--  -dMm/   `-/////::--.`       :dMMMm+`      `..-:::////:`   -dMm/  -:`");
            Console.WriteLine("                          `-:` `oNNy-                   `sNMMMMMMh-                   `oNNy.  --`");
            Console.WriteLine("                           `.:`  :hNNy/::::::::::--....:hNNNNNmNNNd/....--::::::::::/smNd/  `:-`");
            Console.WriteLine("                             .:. `osymMMMMMMMMMMMMdo+/////::::::::////+ohNMMMMMMMMMMMmhss. .:.`");
            Console.WriteLine("                              `-:``ymhshdNMMMMMMMMMMMMNNNNNNNNNNNNNNNMMMMMMMMMMMMNmhyydd- --`");
            Console.WriteLine("                               `.:.`sNMmdhhdNMMMNdmNmmMMMMMMMMMMMMMMNmhhhyyyyyyssshmNMh.`:-`");
            Console.WriteLine("                                 `--`/mMMMMMNMMMmdmdddNNNNNNNNNNNNmdy+:::---....:+ydmo`--`");
            Console.WriteLine("                                   .:--hMMMMNNmdysoo+ooso:--------//-`           ./o:.:.`");
            Console.WriteLine("                                    `-:-sNMMNdyo:.``````-/.     `:-`            `.-.--`");
            Console.WriteLine("                                      `-:+dNNdo:`        -/     -:`             `.`.`");
            Console.WriteLine("                                       `.:/ydy+-        `:-     ./`               `");
            Console.WriteLine("                                         `.-/:-`        ./`      :-");
            Console.WriteLine("                                            ```         -:       -:");
            Console.WriteLine("                                                        -:       -:");
            Console.WriteLine("                                                        ./       ::");
            Console.WriteLine("                                                        ./`      /.");
            Console.WriteLine("                                                        `:-     ./`");
            Console.WriteLine("                                                         -/     --");
            Console.WriteLine("                                                         ./`    /.");
            Console.WriteLine("                                                          -:`  --`");
            Console.WriteLine("                                                           `...``");
            Console.WriteLine("      `...`     `....``    `..`      `..`     `..`     `....``      `....`   `.`    ..`   `..     `....`    `...`");
            Console.WriteLine("    `smmddd/  `sdmmmmmd+   mNNm/    -mNNm`    hNNm.    hNNddmdo   .ymmmmmmh: oNm-  /NN- -odMM-   :dmmNNd/  odddNNh`");
            Console.WriteLine("    /MM:` .. `dMh-  `/NMo  MMyMN.  `dMsMM`   oMhhMh    dMy  +MM. -NMs.  `oMM/ sMm.:NN:  so+MM-   .:``:MMd  -.  +MM/");
            Console.WriteLine("    `hNNhs:` /MM-     hMm  MM/sMh  yMs:MM`  -NN..NM+   dMmssmMs  sMN`     mMh  sMdNN:     -MM-       oMN/   osymNs`");
            Console.WriteLine("      -/yNMd`+MM-     hMm  MM:`mMo/Md`:MM` `dMh//hMN.  dMd//oNMs sMN`     NMy   yMM/      -MM-     -hMd:    //+yMNo");
            Console.WriteLine("    --```oMM..mMh.```+MN/  MM: -MMNN- :MM` sMmyyyymMd` dMy```dMd -NMs.``.sMN-   /MM`    ``:MM:`  .yMN+```  -```.NMm");
            Console.WriteLine("    +mmddNd:  .smNmdmmy:   NN:  oNN+  :NN`-NN-    -NN+ hNmddmms.  -yNNddNms.    /NN`    sdmNNmd+ yNNmmmmm:`dmddNNy-");
            Console.WriteLine("      ...`       `...      ``    ``    ``  ``      ```  ````         `..`        ``     ```````   ```````   `...   ");
            Console.WriteLine("");
            TcpClient tcpClient = new TcpClient();
                    int port = 80;
                    TcpClient client;
                    Console.WriteLine("Pinger V1.0");
                    Console.WriteLine("Made by: Somaboy123");
                    Console.WriteLine("Enter IP or URL:");
                    string ip = Console.ReadLine();
                    Ping ping = new Ping();
                    PingReply pingresult = ping.Send(ip);
                    if(pingresult.Status.ToString() == "Success"){
                        Console.WriteLine("Online");
                    }else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Offline");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine("Want to use Pinger again? (y/n)");
                    switch(Console.ReadLine()){
                        case "y":
                        Console.Clear();
                        goto Start;

                        case "n":
                        break;
                    }
        }
    }
}
