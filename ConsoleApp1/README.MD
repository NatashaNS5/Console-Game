### Игра
class Game {

 //персонаж
 val user: User

 // Уровни
 var levels : List<Level>

 // Текущий уровень
 var currentLevel: Level?
}

### Пользователь
class User { 
 var name: String
 var hero: Hero
}

### Персонаж
class Personage
{
    var name: String
    // Максимальное здоровье
    var health: UInt
    // Текущее здоровье
    var currentHealth: UInt
    // Сила
    var strong: Int
    // Защита
    var protected: Int
    // Уровень
    var level: UInt
    // Минимальная атака
    var minAttack: Int
     // Максимальная атака
    var maxAttack: Int
}

### Герой
class Hero: Personage
 {
    // Опыт
    var exp: UInt
}

### Противник
class Opponent: Personage
{

}

### Босс
class Boss: Personage
{

}

### Уровень
class Level {
    var number: UInt
    var name: String
    var opponents: List<Opponent>
    var boss: Boss 
    var reward: Reward
}

### Награда
class Reward {
    // Опыт
    var exp: Int
    // Максимальное здоровье
    var health: UInt
    // Сила
    var strong: Int
    // Защита
    var protected: Int
}


