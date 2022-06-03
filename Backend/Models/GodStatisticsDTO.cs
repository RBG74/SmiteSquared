namespace Backend.Models
{
    public class GodStatisticsDTO
    {
        public GodStatisticsDTO(SmiteApiLib.Models.DTO.GodDTO source)
        {
            AttackSpeed = source.AttackSpeed;
            AttackSpeedPerLevel = source.AttackSpeedPerLevel;
            Health = source.Health;
            HealthPerLevel = source.HealthPerLevel;
            HealthPerFive = source.HealthPerFive;
            HealthPerFivePerLevel = source.Hp5PerLevel;
            Mana = source.Mana;
            ManaPerLevel = source.ManaPerLevel;
            ManaPerFive = source.ManaPerFive;
            ManaPerFivePerLevel = source.Mp5PerLevel;
            MagicalPower = source.MagicalPower;
            MagicalPowerPerLevel = source.MagicalPowerPerLevel;
            PhysicalPower = source.PhysicalPower;
            PhysicalPowerPerLevel = source.PhysicalPowerPerLevel;
            MagicProtection = source.MagicProtection;
            MagicProtectionPerLevel = source.MagicProtectionPerLevel;
            PhysicalProtection = source.PhysicalProtection;
            PhysicalProtectionPerLevel = source.PhysicalProtectionPerLevel;
            Speed = source.Speed;
        }

        public double AttackSpeed { get; set; }
        public double AttackSpeedPerLevel { get; set; }
        public long Health { get; set; }
        public long HealthPerLevel { get; set; }
        public long HealthPerFive { get; set; }
        public double HealthPerFivePerLevel { get; set; }
        public long Mana { get; set; }
        public long ManaPerLevel { get; set; }
        public double ManaPerFive { get; set; }
        public double ManaPerFivePerLevel { get; set; }
        public long MagicalPower { get; set; }
        public double MagicalPowerPerLevel { get; set; }
        public long PhysicalPower { get; set; }
        public double PhysicalPowerPerLevel { get; set; }
        public long MagicProtection { get; set; }
        public double MagicProtectionPerLevel { get; set; }
        public long PhysicalProtection { get; set; }
        public double PhysicalProtectionPerLevel { get; set; }
        public long Speed { get; set; }
    }
}