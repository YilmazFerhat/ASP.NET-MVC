public ActionResult Admin()
{
    var insurees = db.Insurees.ToList();
    return View(insurees);
}
