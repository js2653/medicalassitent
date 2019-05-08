using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using medicalassitent.web.Data;
using medicalassitent.web.Data.Entities;

namespace medicalassitent.web.Controllers
{
    public class AnalyticsController : Controller
    {
        private readonly DataContext _context;

        public AnalyticsController(DataContext context)
        {
            _context = context;
        }

        // GET: Analytics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Analytics.ToListAsync());
        }

        // GET: Analytics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analytics = await _context.Analytics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (analytics == null)
            {
                return NotFound();
            }

            return View(analytics);
        }

        // GET: Analytics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Analytics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_Paciente,Id_Medico,Fecha,No_Historia,Ac_Urico,Albumina,Amilasa,Billirubina,Calcio,Ck_Total,Ck_MB,Col_Total,Col_HDL,Col_LDL,Col_VLDL,CurGluc_Hora,Cloro,Creatinina,Ferritina,Fos_Alcalina,FosfAcTotal,FosfAcNoProst,FosfAcProst,Fosfolipidos,Fosforo,Gluc_Ayunas,Gluc_Prandial,Gluc_Gluc,Gluc_Capilar,Hem_Gluc,GGTP,Hi_Serico,Cap_Hierro,Inm_lgA,Inm_Lgc,Inm_Lgm,Ldh,Lipasa,Lip_Tot,Magnesio,Microal_Cuant,Potasio_K,Prot_Total,Prot_Frac,Sodio_Na,SGCT,SGTP,Trigliceridos,Tropl_Cualit,TropT_Cualit,TropT_Cuanti,Urea,Bacil_En,Bacil_Ser,Cultivo,TincGram_en,Cont_Sangre,Cont_Nasal,Cont_Retic,Eritrosedimentacion,Falcemia,Hemograma,Hemotozoarios,Tiemp_Prot,Tiemp__Tromb,Tiemp_Sang,Tiemp_Coag,Ant_Feb,ASO_Latex,ASO_Cuant,C3,C4,Dengue_Lgg,Dengue_Lgm,Fac_Latex,Fac_Cuant,HTLV,Lep_Lgg,Lep_Lgm,Pcr_Latex,Pcr__Cuant,PCR_Ultra,Prueba_Orina,Prueba_Sangre,Tb_Micodot,Tip_Sang,Prueb_Directa,Prueb_Indirecta,Vdrl,Acido_Folico,Antic_Antit,Anti_Hav,AntiHav_Lgg,AntiHbc,AntiHbe,Hbcg,Cortisol,Cort_Muest,Cort_Pm,Elect_Hb,Elect_MAcid,Estrogenos_Totales,Fsh,HepatB_Ag,Hepat_HVC,Antigeno_Ag,HIV,Hormona_Basal,Hormona_Est,Inmunoglobina,Lh,Progesterona,Prolactina,T3,T3_Libre,T4,T4_Libre,Tsh,Testoterona,Tiroglobulina,Toxo_Lgg,Toxo_Lgm,Vitaminas_B,Ana,Anti_Dna,Celulas_Le,Monotest,Alfp,Cea,Cea_15,Cea_19,Cea_125,Antidoping_CocMar,Antidoping_Panel,Depur_Creat,Examen_Orina,Proteina_Orina,Proteina_BJ,Coprologico,Coprologico_X2,Coprologico_X3,Coprologico_Conc,Dig_Heces,H_Pilory,Oxiuros_Cinta,Rotavirus,Sust_Reduc,Sangre_Oculta,Colera,Otros,Dx,WasDeleted")] Analytics analytics)
        {
            if (ModelState.IsValid)
            {
                _context.Add(analytics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(analytics);
        }

        // GET: Analytics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analytics = await _context.Analytics.FindAsync(id);
            if (analytics == null)
            {
                return NotFound();
            }
            return View(analytics);
        }

        // POST: Analytics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_Paciente,Id_Medico,Fecha,No_Historia,Ac_Urico,Albumina,Amilasa,Billirubina,Calcio,Ck_Total,Ck_MB,Col_Total,Col_HDL,Col_LDL,Col_VLDL,CurGluc_Hora,Cloro,Creatinina,Ferritina,Fos_Alcalina,FosfAcTotal,FosfAcNoProst,FosfAcProst,Fosfolipidos,Fosforo,Gluc_Ayunas,Gluc_Prandial,Gluc_Gluc,Gluc_Capilar,Hem_Gluc,GGTP,Hi_Serico,Cap_Hierro,Inm_lgA,Inm_Lgc,Inm_Lgm,Ldh,Lipasa,Lip_Tot,Magnesio,Microal_Cuant,Potasio_K,Prot_Total,Prot_Frac,Sodio_Na,SGCT,SGTP,Trigliceridos,Tropl_Cualit,TropT_Cualit,TropT_Cuanti,Urea,Bacil_En,Bacil_Ser,Cultivo,TincGram_en,Cont_Sangre,Cont_Nasal,Cont_Retic,Eritrosedimentacion,Falcemia,Hemograma,Hemotozoarios,Tiemp_Prot,Tiemp__Tromb,Tiemp_Sang,Tiemp_Coag,Ant_Feb,ASO_Latex,ASO_Cuant,C3,C4,Dengue_Lgg,Dengue_Lgm,Fac_Latex,Fac_Cuant,HTLV,Lep_Lgg,Lep_Lgm,Pcr_Latex,Pcr__Cuant,PCR_Ultra,Prueba_Orina,Prueba_Sangre,Tb_Micodot,Tip_Sang,Prueb_Directa,Prueb_Indirecta,Vdrl,Acido_Folico,Antic_Antit,Anti_Hav,AntiHav_Lgg,AntiHbc,AntiHbe,Hbcg,Cortisol,Cort_Muest,Cort_Pm,Elect_Hb,Elect_MAcid,Estrogenos_Totales,Fsh,HepatB_Ag,Hepat_HVC,Antigeno_Ag,HIV,Hormona_Basal,Hormona_Est,Inmunoglobina,Lh,Progesterona,Prolactina,T3,T3_Libre,T4,T4_Libre,Tsh,Testoterona,Tiroglobulina,Toxo_Lgg,Toxo_Lgm,Vitaminas_B,Ana,Anti_Dna,Celulas_Le,Monotest,Alfp,Cea,Cea_15,Cea_19,Cea_125,Antidoping_CocMar,Antidoping_Panel,Depur_Creat,Examen_Orina,Proteina_Orina,Proteina_BJ,Coprologico,Coprologico_X2,Coprologico_X3,Coprologico_Conc,Dig_Heces,H_Pilory,Oxiuros_Cinta,Rotavirus,Sust_Reduc,Sangre_Oculta,Colera,Otros,Dx,WasDeleted")] Analytics analytics)
        {
            if (id != analytics.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(analytics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnalyticsExists(analytics.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(analytics);
        }

        // GET: Analytics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analytics = await _context.Analytics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (analytics == null)
            {
                return NotFound();
            }

            return View(analytics);
        }

        // POST: Analytics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var analytics = await _context.Analytics.FindAsync(id);
            _context.Analytics.Remove(analytics);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnalyticsExists(int id)
        {
            return _context.Analytics.Any(e => e.Id == id);
        }
    }
}
