using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ship_Review.Models;
using System.Reflection;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Ship_Review.Data;

namespace Ship_Review.Controllers
{
    public class UploadController : Controller
    {

        private readonly ApplicationDbContext _context;

        public UploadController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UploadController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validate(XMLandSchemaFileUpload model)
        {
            if (ModelState.IsValid)
            {

                List<XmlValidationError> errors = new List<XmlValidationError>();
                try
                {
                    using (XmlReader schemaReader = XmlReader.Create(model.SchemaFile.OpenReadStream()))
                    {
                        XmlSchemaSet sc = new XmlSchemaSet();
                        sc.Add(null, schemaReader);

                        // Set the validation settings.
                        XmlReaderSettings settings = new XmlReaderSettings();
                        settings.ValidationType = ValidationType.Schema;
                        settings.Schemas = sc;

                        // Validation event handler
                        settings.ValidationEventHandler += (s, e) =>
                        {
                            errors.Add(new XmlValidationError
                            {
                                Element = ((XmlReader)s).Name,
                                ErrorType = e.Severity.ToString(),
                                Line = e.Exception.LineNumber,
                                Column = e.Exception.LinePosition,
                                Message = e.Message
                            });
                        };
                        XmlReader xmlReader = XmlReader.Create(model.XMLFile.OpenReadStream(), settings);
                        while (xmlReader.Read())
                        {
                            // Do nothing, only want to validate the XML file.
                        }





                        if (errors.Count == 0)
                        {
                            SaveToDatabase(xmlReader);
                            TempData["SuccessMessage"] = $"No error found when validating {model.XMLFile.FileName} against {model.SchemaFile.FileName}. Successfully saved to database.";

                            

                            return View("ValidationResult");
                            //return RedirectToAction("ValidationResult");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
                }

                if (errors.Count > 0)
                {
                    ViewData["XmlFileName"] = model.XMLFile.FileName;
                    ViewData["SchemaFileName"] = model.SchemaFile.FileName;

                    return View("ValidationResult", errors);
                }

                //if (errors.Count > 0)
                //{
                //    TempData["ErrorMessages"] = errors;
                //    return View("Errors");
                //}
                //else
                //{
                //    TempData["SuccessMessage"] = "XML file is valid!";
                //    return View("Success");
                //}


            }
            return View("Index", model);


        }

        private void SaveToDatabase(XmlReader xmlReader)

        {
            ships ships = GetShipsFromXML();
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(ships));

            //var ships = (ships)serializer.Deserialize(xmlReader);

            foreach(shipsShip ship in ships.ship)
            {
                var existingShip = _context.ShipInfos.FirstOrDefault(s => s.Imo == ship.imo);
                if (existingShip != null)
                {
                    // Update existing ShipInfo
                    UpdateExistingShip(existingShip, ship);
                }
                else
                {
                    // Create a new ShipInfo
                    CreateNewShip(ship);
                }

                _context.SaveChanges();

                CreateNewShipEvaluation(ship);

            }

            //foreach (var ship in ships.ship)
            //{
            //    var existingShip = _context.ShipInfos.FirstOrDefault(s => s.Imo == ship.imo);
            //    if (existingShip != null)
            //    {
            //        // Update existing ShipInfo
            //        UpdateExistingShip(existingShip, ship);
            //    }
            //    else
            //    {
            //        // Create a new ShipInfo
            //        CreateNewShip(ship);
            //    }


            //}

            _context.SaveChanges();

        }

        private ships GetShipsFromXML()
        {
            ships ships = null;

            string xmlPath = Path.GetFullPath("Data/ship_reviews.xml");
            using (FileStream xs = new FileStream(xmlPath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ships));
                ships = serializer.Deserialize(xs) as ships;

            }


            return ships;
        }

        

        private void UpdateExistingShip(ShipInfo existingShip, shipsShip ship)
        {
            existingShip.Name = ship.name;
            existingShip.Imo = (int)ship.imo;
            existingShip.Type = ship.type.ToString();
     

            existingShip.Flag = ship.flag;
            existingShip.GrossTon = ship.gross_ton;
            existingShip.Dwt = ship.dwt;
            existingShip.Length = ship.length;
            existingShip.Beam = ship.beam;
            existingShip.Draught = ship.draught;
            existingShip.Photo = ship.photo;
            existingShip.BuildYear = ship.build_year;
            existingShip.Owner = ship.owner;
            existingShip.Manager = ship.manager;

        }

        private void CreateNewShip(shipsShip ship)
        {

            var newShip = new ShipInfo
            {
                Name = ship.name,
                Imo = (int)ship.imo,
                Type = ship.type.ToString(),
                Flag = ship.flag,
                GrossTon = ship.gross_ton,
                Dwt = ship.dwt,
                Length = ship.length,
                Beam = ship.beam,
                Draught = ship.draught,
                Photo = ship.photo,
                BuildYear = ship.build_year,
                Owner = ship.owner,
                Manager = ship.manager


            };

            _context.ShipInfos.Add(newShip);




        }
        private void CreateNewShipEvaluation(shipsShip ship)
        {
            var newEvaluation = new ShipEvaluation
            {
                VesselQualityMin = ship.ship_evaluation.vessel_quality.min,
                VesselQualityMax = ship.ship_evaluation.vessel_quality.max,
                VesselQualityValue = ship.ship_evaluation.vessel_quality.Value,

                CrewPerformanceMin = ship.ship_evaluation.crew_performance.min,
                CrewPerformanceMax = ship.ship_evaluation.crew_performance.max,
                CrewPerformanceValue = ship.ship_evaluation.crew_performance.Value,

                CrewAttitudeMin = ship.ship_evaluation.crew_attitude.min,
                CrewAttitudeMax = ship.ship_evaluation.crew_attitude.max,
                CrewAttitudeValue = ship.ship_evaluation.crew_attitude.Value,

                FuelEfficiencyMin = ship.ship_evaluation.fuel_efficiency.min,
                FuelEfficiencyMax = ship.ship_evaluation.fuel_efficiency.max,
                FuelEfficiencyValue = ship.ship_evaluation.fuel_efficiency.Value,

                SafetyScoreMin = ship.ship_evaluation.safety_score_by_third_party.min,
                SafetyScoreMax = ship.ship_evaluation.safety_score_by_third_party.max,
                SafetyScoreValue = ship.ship_evaluation.safety_score_by_third_party.Value,

                Imo = (int)ship.imo

                 
            };

            _context.ShipEvaluations.Add(newEvaluation);
        }
    }
}
