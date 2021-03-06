﻿using System;
using System.Windows.Forms;

namespace FightClub_2
{
    #region Бойцовский клуб
    //
    // Разработать игровую программу
    // Игровой процесс
    // В игре участвуют два игрока.Роль второго игрока исполняет компьютер.
    // Игра строится на основе раундов.
    // В одном раунде один игрок атакует, другой защищается. Атакующий игрок выбирает для удара часть
    // тела оппонента (голова, корпус, ноги). Защищающийся игрок выбирает часть тела для блока(голова,
    // корпус, ноги). В момент окончания раунда наступает подсчет результата.
    // * Если выбор части тела атакующим и защищающимся игроком совпали удар считается
    // заблокированным и очки здоровья не снимаются.
    // * Если выбор части тела атакующим и защищающимся игроком не совпали удар считается
    // нанесенным и у защищающегося игрока уменьшаются очки здоровья.
    // После нанесения ударов проверяется количество очков здоровья у защищаюсего игрока.
    // - Если очки здоровья защищаюсегося игрока меньше или равны нулю он считается мертвым и
    // атакующий игрок побеждает.
    // - Если очки здоровья защищаюсегося игрока больше нуля раунд считается оконченным и
    // игроки меняются местами(атакующий становится защищающимся)

    //Требования:
    // 1. Сущность Игрок должна содержать поля Имя игрока(Name), Заблокированную часть тела
    // (Blocked) и Очки здоровья(Hp)
    // 2. Части тела для удобства должны реализваться с помощью перечисления
    // 3. Сущность Игрок должна содержать методыGetHitпринимающий часть тела для удара и
    // SetBlock для выбора защищаемой части тела
    // 4. У сущности игрок должны быть события Блок(Block), Получения урода(Wound) и Смерти
    // (Death)
    // 5. Аргументы событий должны возвращать имя игрока и текущие очки здоровья.

    // Интерфейс
    // 1. Интерфейс программы разрабатывается с помощью WinForms
    // 2. На интерфейсе должны отображаться
    // a.Имена игроков
    // b.Очки здоровья в числовом и графическом формате (progressbar)
    // c. Программа должна вести лог боя в текстовом виде
    //
    #endregion
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
