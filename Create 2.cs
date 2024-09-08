[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create([Bind(Include = "FirstName,LastName,Email,CarYear,CarMake,CarModel,SpeedingTickets,HasDUI,CoverageType,DateOfBirth")] Insuree insuree)
{
    if (ModelState.IsValid)
    {
        insuree.Quote = CalculateQuote(insuree);
        db.Insurees.Add(insuree);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(insuree);
}
