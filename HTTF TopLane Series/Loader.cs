﻿using System;
using EloBuddy;
using System.Drawing;

namespace HTTF_TopLane_Series

{ 

    class Loader

{
    static void Main(string[] args)
    {
        EloBuddy.SDK.Events.Loading.OnLoadingComplete += Loading;
       
    }
    static void Loading(EventArgs args)
    {
        if (Player.Instance.ChampionName == "Irelia")
        {
                DataChapmion.Irelia.IreliaLoading();
        }

            if (Player.Instance.ChampionName == "Pantheon")
            {
                DataChampion.Pantheon.PantheonLoading();
            }

            if (Player.Instance.ChampionName == "Malphite")
            {
                DataChapmion.Malphite.MalphiteLoading();
            }
            if (Player.Instance.ChampionName == "Poppy")
            {
                DataChampion.Poppy.PoppyLoading();
            }
            if (Player.Instance.ChampionName == "Shen")
            {
                DataChampion.Shen3.ShenLoading();
            }
            if (Player.Instance.ChampionName == "Renekton")
            {
                DataChampion.Renekton.RenektonLoading();
            }

            HTTF_TopLane_Series.Main.Load();
            Chat.Print("HTTF Top Lane Series ", Color.LightSkyBlue);
            Chat.Print("Have Fun And Dont Feed :3 ", Color.DarkSeaGreen);
            return;
    }
}
}