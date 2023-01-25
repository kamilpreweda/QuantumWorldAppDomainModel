using QuantumWorldAppDomainModel.Domain;

var resources = new List<Resource>()
{   new CarbonFiberResource(),
    new QuantumGlassResource(),
};
var buildings = new List<Building>()
{
    new CarbonFiberFactory(),
    new QuantumGlassFactory(),
};
var research = new List<Research>()
{
    new TheExpanseResearch(),
    new ArtOfWarResearch(),
};
var ships = new List<Ship>()
{
    new LightFighterShip(),
    new HeavyFighterShip(),
};
var enemies = new List<Enemy>()
{
    new PiratesEnemy(),
    new OutsidersEnemy(),
};
var battle = new Battle();

var user = new User(resources, buildings, research, ships, enemies, battle);

foreach (var resource in resources)
{
    Console.WriteLine($"Player has {resource.Value} of {resource.Name}");
}
Console.WriteLine();

foreach (var building in buildings)
{
    Console.WriteLine($"Current {building.Name} level = {building.Level}");
    Console.WriteLine($"Current {building.Name} time to build = {building.TimeToBuild}");
}
Console.ReadLine();

Console.WriteLine("Press 1 to upgrade Carbon Fiber Factory");
Console.WriteLine("Press 2 to upgrade Quantum Glass Factory");

var userInput = Console.ReadKey(true).KeyChar.ToString();

if (userInput == "1")
{
    user.UpgradeBuilding(BuildingType.CarbonFiberFactory);
    Console.WriteLine($"current carbon fiber factory level = {buildings.SingleOrDefault(b => b.Type == BuildingType.CarbonFiberFactory).Level}");
    Console.WriteLine($"current carbon fiber factory time to build = {buildings.SingleOrDefault(b => b.Type == BuildingType.CarbonFiberFactory).TimeToBuild}");    
}
if (userInput == "2")
{
    user.UpgradeBuilding(BuildingType.QuantumGlassFactory);
    Console.WriteLine($"current quantum glass factory level = {buildings.SingleOrDefault(b => b.Type == BuildingType.QuantumGlassFactory).Level}");
    Console.WriteLine($"current quantum glass factory time to build = {buildings.SingleOrDefault(b => b.Type == BuildingType.QuantumGlassFactory).TimeToBuild}");
}
foreach (var resource in resources)
{
    Console.WriteLine($"Player now has {resource.Value} of {resource.Name}");
}
Console.ReadLine();

foreach (var r in research)
{
    Console.WriteLine($"Current {r.Name} level = {r.Level}");
    Console.WriteLine($"Current {r.Name} time to build = {r.TimeToBuild}");
}
Console.ReadLine();

Console.WriteLine("Press 1 to upgrade The Expanse Research");
Console.WriteLine("Press 2 to upgrade Art Of War Research");

var researchInput = Console.ReadKey(true).KeyChar.ToString();

if (researchInput == "1")
{
    user.UpgradeResearch(ResearchType.TheExpanseResearch);
    Console.WriteLine($"current The Expanse Research level = {research.SingleOrDefault(r => r.Type == ResearchType.TheExpanseResearch).Level}");
    Console.WriteLine($"current The Expanse Research time to build = {research.SingleOrDefault(r => r.Type == ResearchType.TheExpanseResearch).TimeToBuild}");
}
if (researchInput == "2")
{
    user.UpgradeResearch(ResearchType.ArtOfWarResearch);
    Console.WriteLine($"current Art Of War Research level = {research.SingleOrDefault(r => r.Type == ResearchType.ArtOfWarResearch).Level}");
    Console.WriteLine($"current Art Of War Research time to build = {research.SingleOrDefault(r => r.Type == ResearchType.ArtOfWarResearch).TimeToBuild}");
}
foreach (var resource in resources)
{
    Console.WriteLine($"Player now has {resource.Value} of {resource.Name}");
}



