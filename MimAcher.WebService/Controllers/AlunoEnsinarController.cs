﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MimAcher.Infra;
using MimAcher.Aplicacao;

namespace MimAcher.WebService.Controllers
{
    public class AlunoEnsinarController : Controller
    {
        public GestorDeEnsinoDeAluno GestorDeEnsinoDeAluno { get; set; }

        public AlunoEnsinarController()
        {
            this.GestorDeEnsinoDeAluno = new GestorDeEnsinoDeAluno();
        }

        // GET: AlunoEnsinar
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            List<MA_ALUNO_ENSINAR> listaalunoensino = GestorDeEnsinoDeAluno.ObterTodosOsRegistros();

            JsonResult jsonResult = Json(new
            {
                data = listaalunoensino
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }
    }
}