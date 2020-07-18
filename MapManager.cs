using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class MapManager
{
   public static Tile[,] map; //2х мерная карта с информацией о тайлах
}

[Serializable] //
public class Tile { //содержит информацию каждого отдельного тайла
    public int xPosition; //позиция по оХ
    public int yPosition; //позиция по оУ
    [NonSerialized]
    public GameObject baseObject; //содержит информацию о объекте и его позиции
}
