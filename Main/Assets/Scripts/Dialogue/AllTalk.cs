using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class AllTalk
{
    public static int language_number = 0;
    public static int language_change_rate = 14; // 


    public static string[] contents = new string[] {
        //
        "Recently, the companions in the forest have become strange, and I think what the sage of the North must know.)。", // 0
        "Your time is running out and your movements are fast." , // 未完成 1
        "All the things you want are here, please hurry to save companions in the forest." ,
        "よくやった" ,  //完成 2-3
        "My body is weird…, is it…" ,
        "I also become…Monster…" ,
        "Arghhh…" ,// 4~6 死亡 time up

        "Is Sage there?","I am Sage,Song Song.", "How have the companions in the forest become strange recently? What happened?",  // 789
        "Do you remember the earthquake in the past few days? It was caused by a meteorite falling in the forest in the south. The material on the meteorite that does not belong to this world has caused everyone to change. It is fast to change from your situation.",
        "なに","I have already worked in the solution, but I am missing something. Would you help me finf it?" ,  //12
        "もちろん", "Very good, then I will hand it over to you. They are the fruit of the Western Ice Tree and the Spring Eye of the Eastern Flame Spring. Your time is running out and your movements are fast.", // 14

        //+14

        "最近森林的同伴都變的怪怪的，想必北方的賢者必定知道些什麼。" , //0
        "你的時間已經不多了，快去找吧。" , // 未完成 1
        "賢者阿~ 你要的東西都在這了，請趕快救救森林的同伴們吧。" ,
        "做得很好(よくやった)" ,  //完成 2-3
        "主角: 怎摸感覺身體怪怪的，難道…" ,
        "我也要… 變成… 那樣的怪物了嗎…" ,
        "阿~…" ,// 4~6 死亡 time up

        "賢者阿 賢者阿 你在嗎?","我乃賢者松松是也", "最近森林怎麼同伴都變的怪怪的，是發生了什麼事?",  // 789
        "記得前幾天的地震嗎，那是森林有顆隕石掉在南方所造成的，那隕石上面有著不屬於這個世界的物質導致大家都異變了，看你的狀態，也快了呢",
        "納尼(なに)","我已經快要研究出解決辦法了，可是我還缺了一些東西，你願意去幫我找回來嗎" ,  //12
        "當然(もちろん)", "很好，那就交給你了，分別是西方冰靈樹的果實 跟 東方烈焰泉的泉眼 ，你的時間不多了，動作快。" // 14
    };
    public static string[] people = new string[] {
        "主角" , "Song Song", "主角", "Song Song" ,  "主角" ,  "主角" ,  "主角",  //(0-6)
        "主角" , "Sage" , "主角" , "Song Song" , "主角" , "Song Song" , "主角" ,  "Song Song"// 7-14
        ,
        //+14

        "主角" , "松松", "主角", "松松" ,  "主角" ,  "主角" ,  "主角" ,//0-6
        "主角" , "賢者(吉祥物)" , "主角" , "松松" , "主角" , "松松" , "主角" ,  "松松"// 7-14
      


    };
    public static string[] types =
    {
        "plant", "not","asd"  // Currently Useless
    };

}
