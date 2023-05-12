using MelonLoader;
using Il2Cpp;
using normal_instakill_resistances;
using Il2Cppresult2_H;

[assembly: MelonInfo(typeof(NormalInstakillResistances), "Normal Instakill resistances", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace normal_instakill_resistances;
public class NormalInstakillResistances : MelonMod
{
    public override void OnInitializeMelon()
    {
        // For each Magatama
        foreach (fclHearts_t magatama in tblHearts.fclHeartsTbl)
        {
            // Gets the id of the Magatama's affinities
            short affinitiesID = magatama.AisyoID;

            // Every Resist Light/Dark is replaced by a normal resistance to Light/Dark
            if (datAisyo.tbl[affinitiesID][6] == 50) datAisyo.tbl[affinitiesID][6] = 100;
            if (datAisyo.tbl[affinitiesID][7] == 50) datAisyo.tbl[affinitiesID][7] = 100;
        }
    }
}
