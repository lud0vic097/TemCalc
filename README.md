# TemCalc
Temdata and techniques are scriptable objects setups which are basically "forms you fill in" in unity  and then you can use their values all over the place so basically they are data buckets and don't need to be touched.
  
The Gyalis file is a Scriptable object file that you make with unity, don't know if copying it as text and changing stuff works fine or if unity gets mad afterwards, Rasler will take care of getting all the tems stats and data setup just in case.  
  
StatCalculator controls the numbers shown in the UI and holds the stat totals of it's corresponding tem, making it reference one of the for tems is a thing you deal with in unity itself by "drag and dropping" so don't worry about that, also it should be fine as is already prolly doesn't need modifications.  

BattleCalc is where stats are processed for damage calculation. Logic for type matchups and all the damage formulas, as well as abilities need to be coded. I believe abilities like Hydrologist affect the modifier bit of the damage formula so probably needs to be linked to the type effectivness
