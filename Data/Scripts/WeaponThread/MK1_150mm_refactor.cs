using VRageMath;
using static WeaponThread.WeaponStructure;
using static WeaponThread.WeaponStructure.WeaponDefinition;
using static WeaponThread.WeaponStructure.WeaponDefinition.ModelAssignmentsDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.HardPointDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.HardPointDef.Prediction;
using static WeaponThread.WeaponStructure.WeaponDefinition.TargetingDef.BlockTypes;
using static WeaponThread.WeaponStructure.WeaponDefinition.TargetingDef.Threat;

namespace WeaponThread
{   // Don't edit above this line
    partial class Weapons
    {
        WeaponDefinition Static150mm => new WeaponDefinition
        {
            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[]
                {
                    new MountPointDef
                    {
                        SubtypeId = "Static150mm",
                        AimPartId = "None",
                        MuzzlePartId = "None",
                        AzimuthPartId = "None",
                        ElevationPartId = "None",
                    },
                    
                },
                Barrels = new []
                {
                    //FIXTHIS "muzzle_barrel_001",
                    "barrel_001",
                },
            },
            Targeting = new TargetingDef
            {
                Threats = new[]
                {
                    Grids,
                },
                SubSystems = new[]
                {
                    Thrust, Utility, Offense, Power, Production, Any,
                },
                ClosestFirst = true, // tries to pick closest targets first (blocks on grids, projectiles, etc...).
                MinimumDiameter = 0, // 0 = unlimited, Minimum radius of threat to engage.
                MaximumDiameter = 0, // 0 = unlimited, Maximum radius of threat to engage.
                TopTargets = 8, // 0 = unlimited, max number of top targets to randomize between.
                TopBlocks = 8, // 0 = unlimited, max number of blocks to randomize between
                StopTrackingSpeed = 0, // do not track target threats traveling faster than this speed
            },
            HardPoint = new HardPointDef
            {
                WeaponName = "Cannon150mm", // name of weapon in terminal
                DeviateShotAngle = 0.3f,
                AimingTolerance = 15f, // 0 - 180 firing angle
                AimLeadingPrediction = Advanced, // Off, Basic, Accurate, Advanced
                DelayCeaseFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).

                Ui = new UiDef
                {
                    RateOfFire = false,
                    DamageModifier = false,
                    ToggleGuidance = false,
                    EnableOverload = false,
                },
                Ai = new AiDef
                {
                    TrackTargets = false,
                    TurretAttached = false,
                    TurretController = false,
                    PrimaryTracking = false,
                    LockOnFocus = false,
                },
                HardWare = new HardwareDef
                {
                    RotateRate = 0f,
                    ElevateRate = 0f,
                    MinAzimuth = -0,
                    MaxAzimuth = 0,
                    MinElevation = -0,
                    MaxElevation = 0,
                    FixedOffset = false,
                    InventorySize = 0.495f,
                    Offset = Vector(x: 0, y: 0, z:0),
                },
                Other = new OtherDef
                {
                    GridWeaponCap = 0,
                    RotateBarrelAxis = 0,
                    EnergyPriority = 2,
                    MuzzleCheck = false,
                    Debug = false,
                },
                Loading = new LoadingDef
                {
                    RateOfFire = 10,
                    BarrelSpinRate = 0, // visual only, 0 disables and uses RateOfFire
                    BarrelsPerShot = 1,
                    TrajectilesPerBarrel = 1, // Number of Trajectiles per barrel per fire event.
                    SkipBarrels = 0,
                    ReloadTime = 300, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    DelayUntilFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    HeatPerShot = 0, //heat generated per shot
                    MaxHeat = 20000, //max heat before weapon enters cooldown (70% of max heat)
                    Cooldown = .999f, //percent of max heat to be under to start firing again after overheat accepts .2-.95
                    HeatSinkRate = 200000, //amount of heat lost per second
                    DegradeRof = false, // progressively lower rate of fire after 80% heat threshold (80% of max heat)
                    ShotsInBurst = 0,
                    DelayAfterBurst = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    FireFullBurst = false,
                },
                Audio = new HardPointAudioDef
                {
                    PreFiringSound = "ArcStaticCannon",
                    FiringSound = "ArcStaticCannon", // WepShipGatlingShot
                    FiringSoundPerShot = true,
                    ReloadSound = "",
                    NoAmmoSound = "",
                    HardPointRotationSound = "WepTurretGatlingRotate",
                    BarrelRotationSound = "WepShipGatlingRotation",
                },
                Graphics = new HardPointParticleDef
                {
                    Barrel1 = new ParticleDef //FIXTHIS
                    {
                        Name = "MyMuzzleLarge", // Smoke_LargeGunShot
                        Color = Color(red: 1, green: 1, blue: 1, alpha: 1),
                        Offset = Vector(x: 0, y: 0, z: 0),
                        Extras = new ParticleOptionDef
                        {
                            Loop = false,
                            Restart = false,
                            MaxDistance = 500,
                            MaxDuration = 1,
                            Scale = 2f,
                        },
                    },
                    Barrel2 = new ParticleDef //FIXTHIS
                    {
                        Name = "",//Muzzle_Flash_Large
                        Color = Color(red: 10, green: 0, blue: 0, alpha: 1),
                        Offset = Vector(x: 0, y: -1, z: 0),
                        Extras = new ParticleOptionDef
                        {
                            Loop = false,
                            Restart = false,
                            MaxDistance = 150,
                            MaxDuration = 6,
                            Scale = 1f,
                        },
                    },
                },
            },

            Ammos = new[] {
                HEShell330mmAmmo
            },
        };
    }
}
