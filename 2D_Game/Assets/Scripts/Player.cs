using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private static int health = 3;
    private static int coins;
    private static int jumpCount = 1;
    private static float speed = 200;
    private static float jumpForce = 10;

   public static int Health {
        get => health;
        set => health = value;
   }
   public static int CoinsAmount
   {
        get => coins;
        set => coins = value;
   }
    public static int JumpCount
    {
        get => jumpCount;
        set => jumpCount = value;
    }
    public static float Speed
    {
        get => speed;
        set => speed = value;
    }
    public static float JumpForce
    {
        get => jumpForce;
        set => jumpForce = value;
    }
    public static void SetDefaultValues()
    {
        JumpForce = 10;
        Speed = 200;
        JumpCount = 1;
        CoinsAmount = 0;
        Health = 3;
    }
}
