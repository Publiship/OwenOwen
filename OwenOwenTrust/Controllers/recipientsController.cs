using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OwenOwenTrust;
using OwenOwenTrust.Models;

namespace OwenOwenTrust.Controllers
{
    public class recipientsController : Controller
    {
        private OwenOwenTrustContext db = new OwenOwenTrustContext();

        // GET: recipients
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipientsearch">custom class in recipient model</param>
        /// <returns></returns>
        public ActionResult Index(recipientsearch s)
        {
            //check for sorting
            ViewBag.NameSortParm = string.IsNullOrEmpty(s.sortorder) ? "LastName" : s.sortorder == "LastName" ? "LastName_desc" : "LastName";
            ViewBag.IdSortParm = s.sortorder == "PID" ? "PID_desc" : "PID";
            ViewBag.InitialSortParm = s.sortorder == "Firstnames" ? "Firstnames_desc" : "Firstnames";

            //apply search filters here
            s.recipients = db.recipients
            .Where(r =>
               (s.Firstnames == null || r.Firstnames.Contains(s.Firstnames)) &&
               (s.LastName == null || r.LastName.Contains(s.LastName)) &&
               (s.PID == null || r.PID.Contains(s.PID)) &&
               (s.Group == null || r.Group.Equals(s.Group)) &&
               (s.Age == null || r.Group.Equals(s.Age)) &&
               (s.StoreNo == null || r.StoreNo.Equals(s.StoreNo)) &&
               (s.Sex == null || r.Sex.Equals(s.Sex)) &&
               (s.Status == null || r.Status.Equals(s.Status)) 
               );

            //sort after filtering
            switch (s.sortorder)
            {
                case "Firstnames":
                    s.recipients = s.recipients.OrderBy(r => r.Firstnames);
                    break;
                case "Firstnames_desc":
                    s.recipients = s.recipients.OrderByDescending(r => r.Firstnames);
                    break;
                case "LastName_desc":
                    s.recipients = s.recipients.OrderByDescending(r => r.LastName);
                    break;
                case "PID":
                    s.recipients = s.recipients.OrderBy(r => r.PID);
                    break;
                case "PID_desc":
                    s.recipients = s.recipients.OrderByDescending(r => r.PID);
                    break;
                default:
                    s.recipients = s.recipients.OrderBy(r => r.LastName);
                    break;
            }
            
            //return list
            //return View(db.recipients.ToList()); //return from var not from db at this point
            //return View(recipients.ToList());
            return View(s);
        }

        // GET: recipients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recipient recipient = db.recipients.Find(id);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // GET: recipients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: recipients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PID,Class,Group,PayNo,PayMethod,LastName,Firstnames,StoreNo,Title,Sex,Status,DOB,Age,StoreName,Present,Previous,Add1,Addb1,Add2,Addb2,Add3,Addb3,Add4,Addb4,PC1,PC2,Tel,DateofChange,AppEmp,RelEmp,EmpDate,DOL,Service,MName,EmpProof,SID,SEmpDate,SDOL,SService,EnqFrom,InitLet,InitBac,LetType,DOI,SPDetail,Comments,DPC,Commuted,DOD,DON,SP,OOP,OP,UB,WS,IS,OI,ISup,TotI,DIS,AA,DL,HBx,HB,OTT,IncSupx,IncSup,HO,HORent,RENT,RNH,RHH,HHCost,DOT2ISS,DOT2REC,DILISS,DILREC,RWNG,RED,RWRED,RESH,RED2,SG,RWSG,InfChg,DBankDReq,DBankDRec,ValGP,DtoLCSS,DOGP,DOGP2,DOGP3,DOGP4,Value2,PbyP,Period,Commence,BBS,Bank1,Bank2,Bank3,Bank4,BPC,SortCode,ACCTNo,REFNo,BSRef,OGE,DFGP,FGPApp,FGP,FGPChq,XmasGift,XmasToken,NOK,NOKTel,Visitor,VPrev,VChange,VType,CS,FLX,FL,Ded,User,Rel,ChqPD,CTaxYN,CTaxBfit,Water,OthExp,GRent,PropSrv,OthBfit,A,AD,GPS,SDapp,NDT,ReApp,AccStatus,TotBenefit,NetOutgoing,NetBenefit1,NetBenefit2,NetDiff")] recipient recipient)
        {
            if (ModelState.IsValid)
            {
                db.recipients.Add(recipient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recipient);
        }

        // GET: recipients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recipient recipient = db.recipients.Find(id);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // POST: recipients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PID,Class,Group,PayNo,PayMethod,LastName,Firstnames,StoreNo,Title,Sex,Status,DOB,Age,StoreName,Present,Previous,Add1,Addb1,Add2,Addb2,Add3,Addb3,Add4,Addb4,PC1,PC2,Tel,DateofChange,AppEmp,RelEmp,EmpDate,DOL,Service,MName,EmpProof,SID,SEmpDate,SDOL,SService,EnqFrom,InitLet,InitBac,LetType,DOI,SPDetail,Comments,DPC,Commuted,DOD,DON,SP,OOP,OP,UB,WS,IS,OI,ISup,TotI,DIS,AA,DL,HBx,HB,OTT,IncSupx,IncSup,HO,HORent,RENT,RNH,RHH,HHCost,DOT2ISS,DOT2REC,DILISS,DILREC,RWNG,RED,RWRED,RESH,RED2,SG,RWSG,InfChg,DBankDReq,DBankDRec,ValGP,DtoLCSS,DOGP,DOGP2,DOGP3,DOGP4,Value2,PbyP,Period,Commence,BBS,Bank1,Bank2,Bank3,Bank4,BPC,SortCode,ACCTNo,REFNo,BSRef,OGE,DFGP,FGPApp,FGP,FGPChq,XmasGift,XmasToken,NOK,NOKTel,Visitor,VPrev,VChange,VType,CS,FLX,FL,Ded,User,Rel,ChqPD,CTaxYN,CTaxBfit,Water,OthExp,GRent,PropSrv,OthBfit,A,AD,GPS,SDapp,NDT,ReApp,AccStatus,TotBenefit,NetOutgoing,NetBenefit1,NetBenefit2,NetDiff")] recipient recipient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recipient);
        }

        // GET: recipients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recipient recipient = db.recipients.Find(id);
            if (recipient == null)
            {
                return HttpNotFound();
            }
            return View(recipient);
        }

        // POST: recipients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            recipient recipient = db.recipients.Find(id);
            db.recipients.Remove(recipient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
