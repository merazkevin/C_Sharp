

Attack Logic = new Attack("logic", 30);
Attack BehaviorQuest = new Attack("Behavior Question", 30);
Attack RejectLetter = new Attack("Rejection Letter", 40);




Enemy Interviewer = new Enemy("Interviewer", 100);
Interviewer.Attacks.Add(Logic);
Interviewer.Attacks.Add(BehaviorQuest);
Interviewer.Attacks.Add(RejectLetter);
Interviewer.RandAttack();

// foreach(Attack  ii in attackList)
// {
//     Console.WriteLine(ii.Name);
// }