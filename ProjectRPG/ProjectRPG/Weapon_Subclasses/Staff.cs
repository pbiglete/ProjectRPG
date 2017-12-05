﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRPG
{
    class Staff : Weapon
    {
        public Staff()
        {
            Name = "";
            ElementType = "Magic";
            BaseAttack = 0;

            Move1Name = "";
            Move2Name = "";
            Move3Name = "";
            Move4Name = "";

            Move1Ammo = 0;
            Move2Ammo = 0;
            Move3Ammo = 0;
            Move4Ammo = 0;

            Move1MaxAmmo = Move1Ammo;
            Move2MaxAmmo = Move2Ammo;
            Move3MaxAmmo = Move3Ammo;
            Move4MaxAmmo = Move4Ammo;
        }

        public Staff(int StrengthStat)
        {
            Name = GenerateWeapName();
            BaseAttack = (StrengthStat) * Game.Player.LevelNumber * 4 * Game.Player.Intelligence;

            ElementType = "Magic";

            Move1Name = "Fire Cone Blast";
            Move1Ammo = 8;
            Move1Damage = BaseAttack + (Game.Player.Intelligence * 4);
            Move1MaxAmmo = Move1Ammo;

            if (Move1Damage >= 2147483647 || Move1Damage < 0)
                Move1Damage = 2147483647;

            Move2Name = "Ice Cone Blast";
            Move2Ammo = 8;
            Move2Damage = BaseAttack + (Game.Player.Intelligence * 4);
            Move2MaxAmmo = Move2Ammo;

            if (Move2Damage >= 2147483647 || Move2Damage < 0)
                Move2Damage = 2147483647;

            Move3Name = "Lighting Cone Blast";
            Move3Ammo = 8;
            Move3MaxAmmo = Move3Ammo;

            if (Move3Damage >= 2147483647 || Move3Damage < 0)
                Move3Damage = 2147483647;

            Move3Damage = BaseAttack + (Game.Player.Intelligence * 4);

            Move4Name = "Magical Hell Gate";
            Move4Ammo = 2;
            Move4MaxAmmo = Move4Ammo;
            Move4Damage = BaseAttack * 50;

            if (Move4Damage >= 2147483647 || Move4Damage < 0)
                Move4Damage = 2147483647;
        }

        private string GenerateWeapName()
        {
            string[] name = { "Forbidden Book", "Unknown Scripture", "Ender of Worlds", "Harry's Spells" };

            Random rand = new Random();
            int randVal = rand.Next(0, name.Count());

            return ($"{name[randVal]} (Spell Tome)");
        }

        public override void UpdateWeapon(int StrengthStat)
        {
            BaseAttack = (StrengthStat) * Game.Player.LevelNumber * 4 * Game.Player.Intelligence;

            Move1Damage = BaseAttack + (Game.Player.Intelligence * 4);
            if (Move1Damage >= 2147483647 || Move1Damage < 0)
                Move1Damage = 2147483647;

            Move2Damage = BaseAttack + (Game.Player.Intelligence * 4);
            if (Move2Damage >= 2147483647 || Move2Damage < 0)
                Move2Damage = 2147483647;

            Move3Damage = BaseAttack + (Game.Player.Intelligence * 4);
            if (Move3Damage >= 2147483647 || Move3Damage < 0)
                Move3Damage = 2147483647;

            Move4Damage = BaseAttack * 50;
            if (Move4Damage >= 2147483647 || Move4Damage < 0)
                Move4Damage = 2147483647;
        }
    }
}