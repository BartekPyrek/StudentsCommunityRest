using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StudentCommunityRest.Models;

namespace StudentCommunityRest.DAL
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            #region Definiowanie uczelni
            var ug = new Academy { Name = "Universytet Gdański", City = "Gdańsk" };
            var pg = new Academy { Name = "Politechnika Gdańska", City = "Gdańsk" };
            var pjatk = new Academy { Name = "Polsko Japoska Akademia Technik Komputerowych", City = "Gdańsk" };
            var pw = new Academy { Name = "Politechnika Warszawska", City = "Warszawa" };
            var uw = new Academy { Name = "Uniwersytet Warszawski", City = "Warszawa" };
            var wat = new Academy { Name = "Wojskowa Akademia Techniczna", City = "Warszawa" };
            var sgsp = new Academy { Name = "Szkoła Główna Służby Pożarniczej", City = "Warszawa" };
            var sggw = new Academy { Name = "Szkoła Główna Gospodarstwa Wiejskiego", City = "Warszawa" };
            var uj = new Academy { Name = "Uniwersytet Jagiellonski", City = "Krakow" };
            var pk = new Academy { Name = "Politechnika Krakowska", City = "Krakow" };
            var agh = new Academy { Name = "Akademia Górniczo-Hutnicza", City = "Krakow" };
            var amwsz = new Academy { Name = "Akademia Morska", City = "Szczecin" };
            #endregion
            var listaUczelni = new List<Academy>
            {
                ug, pg, pjatk, pw, uw, wat, sgsp, sggw, uj, pk, agh, amwsz
            };
            listaUczelni.ForEach(acdm => context.Academies.Add(acdm));


            #region Definiowanie wydziałow
            //UG
            var ug_mfi = new Department { Academy = ug, Name = "Wydział Matematyki, Fizyki i Informatyki" };
            var ug_hum = new Department { Academy = ug, Name = "Wydział humanistyczny" };
            var ug_chem = new Department { Academy = ug, Name = "Wydział chemiczny" };
            var ug_bio = new Department { Academy = ug, Name = "Wydział biologii" };
            var ug_ekon = new Department { Academy = ug, Name = "Wydział ekonomiczny" };
            var ug_ns = new Department { Academy = ug, Name = "Wydział Nauk Społecznych" };
            var ug_oig = new Department { Academy = ug, Name = "Wydział Oceanogarfii i Geografii" };
            var ug_pia = new Department { Academy = ug, Name = "Wydział Prawa i Administracji" };
            var ug_zarz = new Department { Academy = ug, Name = "Wydział Zarządzania" };

            //PG
            var pg_eti = new Department { Academy = pg, Name = "Wydział Elektroniki, Telekomunikacji i Informatyki" };
            var pg_arch = new Department { Academy = pg, Name = "Wydział Architektury" };
            var pg_chem = new Department { Academy = pg, Name = "Wydział Chemiczny" };
            var pg_eia = new Department { Academy = pg, Name = "Wydział Elektrotechniki i Automatyki" };
            var pg_ftims = new Department { Academy = pg, Name = "Wydział Fizyki Technicznej i Matematyki Stosowanej" };
            var pg_ilis = new Department { Academy = pg, Name = "Wydział Inżynierii Lądowej i Środowiska" };
            var pg_mech = new Department { Academy = pg, Name = "Wydział Mechaniczny" };
            var pg_oio = new Department { Academy = pg, Name = "Wydział Oceanotechniki i Okrętownictwa" };
            var pg_zie = new Department { Academy = pg, Name = "Wydział Zarządzania i Ekonomii" };

            //UW
            var uw_biol = new Department { Academy = uw, Name = "Wydział Biologii" };
            var uw_fiz = new Department { Academy = uw, Name = "Wydział Fizyki" };
            var uw_geolog = new Department { Academy = uw, Name = "Wydział Geologii" };
            var uw_pol = new Department { Academy = uw, Name = "Wydział Polonistyki" };
            var uw_pid = new Department { Academy = uw, Name = "Wydział Prawa i Administracji" };

            //PW
            var pw_fiz = new Department { Academy = pw, Name = "Wydział Fizyki" };
            var pw_eiti = new Department { Academy = pw, Name = "Wydział Elektroniki i Technik Informacyjnych" };
            var pw_inzProd = new Department { Academy = pw, Name = "Wydział Inżynierii Produkcji" };
            var pw_mechEnergILot = new Department { Academy = pw, Name = "Wydział Mechaniczny Energetyki i Lotnictwa" };

            //WAT
            var wat_cyber = new Department { Academy = wat, Name = "Wydział Cybernetyki" };
            var wat_elektr = new Department { Academy = wat, Name = "Wydział Elektroniki" };
            var wat_inzLadIGeo = new Department { Academy = wat, Name = "Wydział Inżynierii Lądowej i Geodezji" };
            var wat_logist = new Department { Academy = wat, Name = "Wydział Logistyki" };
            var wat_mech = new Department { Academy = wat, Name = "Wydział Mechaniczny" };
            var wat_mechtronILot = new Department { Academy = wat, Name = "Wydział Mechatroniki i Lotnictwa" };
            var wat_techIchem = new Department { Academy = wat, Name = "Wydział Nowych Technologii i Chemii" };

            //SGSP
            var sgsp_inzBezpCywil = new Department { Academy = sgsp, Name = "Inżynieria Bezpieczeństwa Cywilnego" };
            var sgsp_inzBezpPozar = new Department { Academy = sgsp, Name = "Inżynieria Bezpieczeństwa Pożarowego" };

            //SGGW
            var sggw_inzProd = new Department { Academy = sggw, Name = "Wydział Inżynierii Produkcji" };
            var sggw_budowInzSrod = new Department { Academy = sggw, Name = "Wydział Budownictwa i Inżynierii Środowiska" };
            var sggw_lesny = new Department { Academy = sggw, Name = "Wydział Leśny" };
            var sggw_medWet = new Department { Academy = sggw, Name = "Wydział Medycyny Weterynaryjnej" };
            var sggw_naukEkonom = new Department { Academy = sggw, Name = "Wydział Nauk Ekonomicznych" };
            var sggw_naukZwierz = new Department { Academy = sggw, Name = "Wydział Nauk o Zwierzętach" };
            var sggw_naukSpole = new Department { Academy = sggw, Name = "Wydział Nauk Społecznych" };
            var sggw_naukZywno = new Department { Academy = sggw, Name = "Wydział Nauk o Żywności" };
            var sggw_ogrodBiotechArchKraj = new Department { Academy = sggw, Name = "Wydział Ogrodnictwa, Biotechnologii i Architektury Krajobrazu" };
            var sggw_infMat = new Department { Academy = sggw, Name = "Wydział Zastosowań Informatyki i Matematyki" };

            //PJATK
            var pjatk_inf = new Department { Academy = pjatk, Name = "Wydział informatyki" };
            var pjatk_snw = new Department { Academy = pjatk, Name = "Wydział Sztuki Nowych Mediow" };

            //UJ
            var uj_bio = new Department { Academy = uj, Name = "Wydział Biologii" };
            var uj_chem = new Department { Academy = uj, Name = "Wydział Chemii" };
            var uj_gig = new Department { Academy = uj, Name = "Wydział Geografii i Geologii" };
            var uj_his = new Department { Academy = uj, Name = "Wydział Historyczny" };
            var uj_pol = new Department { Academy = uj, Name = "Wydział Polonistyki" };

            //PK
            var pk_arch = new Department { Academy = pk, Name = "Wydział Architektury" };
            var pk_ieik = new Department { Academy = pk, Name = "Wydział Inżynierii Elektrycznej i Komputerowej" };
            var pk_itc = new Department { Academy = pk, Name = "Wydział Inżynierii i Technologii Chemicznej" };
            var pk_il = new Department { Academy = pk, Name = "Wydział Inżynierii Lądowej" };
            var pk_is = new Department { Academy = pk, Name = "Wydział Inżynierii Środowiska" };

            //AGH
            var agh_eip = new Department { Academy = agh, Name = "Wydział Energetyki i Paliw" };
            var agh_fis = new Department { Academy = agh, Name = "Wydział Fizyki i Informatyki Stosowanej" };
            var agh_goig = new Department { Academy = agh, Name = "Wydział Górnictwa i Geoinżynierii" };

            //AMWSZ
            var amwsz_naw = new Department { Academy = amwsz, Name = "Wydział Nawigacyjny" };
            var amwsz_mech = new Department { Academy = amwsz, Name = "Wydział Mechaniczny" };
            var amwsz_iet = new Department { Academy = amwsz, Name = "Wydział Inżynieryjno-Ekonomiczny Transportu" };
            #endregion
            var listaWydzialow = new List<Department>
            {
                ug_mfi, ug_hum, ug_chem, ug_bio, ug_ekon, ug_ns, ug_oig, ug_pia, ug_zarz,
                pg_eti, pg_arch, pg_chem, pg_eia, pg_ftims, pg_ilis, pg_mech, pg_oio, pg_zie,
                pjatk_inf, pjatk_snw,
                uw_biol, uw_fiz, uw_geolog, uw_pol, uw_pid,
                pw_fiz, pw_eiti, pw_inzProd, pw_mechEnergILot,
                wat_cyber, wat_elektr, wat_inzLadIGeo, wat_logist, wat_mech, wat_mechtronILot, wat_techIchem,
                sgsp_inzBezpCywil, sgsp_inzBezpPozar,
                sggw_inzProd, sggw_budowInzSrod, sggw_lesny, sggw_medWet, sggw_naukEkonom, sggw_naukZwierz, sggw_naukSpole, sggw_naukZywno,
                sggw_ogrodBiotechArchKraj, sggw_infMat,
                uj_bio, uj_chem, uj_gig, uj_his, uj_pol,
                pk_arch, pk_ieik, pk_itc, pk_il, pk_is,
                agh_eip, agh_fis, agh_goig,
                amwsz_naw, amwsz_mech, amwsz_iet
            };
            listaWydzialow.ForEach(dprt => context.Departments.Add(dprt));

            // definiowanie uzyszkodnikow
            var janusz = new ApplicationUser { UserName = "Janusz", Email = "johny@rock.pl", };
            var michal = new ApplicationUser { UserName = "Michał", Email = "michal@mail.pl" };
            var bartek = new ApplicationUser { UserName = "Bartek", Email = "bartek@pyrek.pl" };
            var marek = new ApplicationUser { UserName = "Marek", Email = "marek@marecki.pl" };

            var userList = new List<ApplicationUser>
            {
                janusz, michal, bartek, marek
            };
            userList.ForEach(usr => context.Users.Add(usr));


            #region definiowanie grup
            ApplicationUser admin = context.Users.Where(usr => usr.UserName == "admin@mail.edu.pl").FirstOrDefault();
            var ug_mfi_g1 = new Group
            {
                Department = ug_mfi,
                Year = 2016,
                Specialization = "Informatyka i baza danych",
                Course = Course.extramural,
                Level = Level.first,
                Members = new List<ApplicationUser> { janusz, michal },
                //CreatedBy = admin,
                CreationDate = DateTime.Now
            };

            var ug_mfi_g2 = new Group
            {
                Department = ug_mfi,
                Year = 2016,
                Specialization = "Informatyka i baza danych",
                Course = Course.fulltime,
                Level = Level.first,
                //CreatedBy = admin,
                CreationDate = DateTime.Now
            };

            var ug_mfi_g3 = new Group
            {
                Department = ug_mfi,
                Year = 2016,
                Specialization = "Informatyka i baza danych",
                Course = Course.extramural,
                Level = Level.second,
                //CreatedBy = admin,
                CreationDate = DateTime.Now
            };
            #endregion
            var listaGrup = new List<Group>
            {
                ug_mfi_g1, ug_mfi_g2, ug_mfi_g3
            };

            listaGrup.ForEach(grp => context.Groups.Add(grp));

            // dodanie moderatora
            context.Moderates.Add(new Moderate { User = bartek, Group = ug_mfi_g1 });
            context.Moderates.Add(new Moderate { User = marek, Group = ug_mfi_g1 });

            // definiowanie postów
            var post1 = new Post { Group = ug_mfi_g1, User = janusz, Datetime = DateTime.Parse("2019-01-20"), Content = "Przypominam o egzaminie z wspolbiegow" };
            var post2 = new Post { Group = ug_mfi_g1, User = bartek, Datetime = DateTime.Parse("2019-01-20"), Content = "Lubie batony " };
            var post3 = new Post { Group = ug_mfi_g1, User = michal, Datetime = DateTime.Parse("2019-01-20"), Content = "Kto poprawia ceSzarpa?" };
            var post4 = new Post { Group = ug_mfi_g1, User = michal, Datetime = DateTime.Parse("2019-01-20"), Content = "CZeść, kto ma coś jedzenie?" };
            var listPost = new List<Post>
            {
                post1, post2, post3, post4
            };
            listPost.ForEach(pst => context.Posts.Add(pst));


            #region komentarze
            var post1_comm1 = new Comment { User = bartek, Post = post1, Datetime = DateTime.Parse("2019-01-19 19:02"), Content = "Fajnie." };
            var post1_comm2 = new Comment { User = michal, Post = post1, Datetime = DateTime.Parse("2019-01-20 10:00"), Content = "Mi sie nie podoba" };
            var post1_comm3 = new Comment { User = janusz, Post = post1, Datetime = DateTime.Parse("2019-01-21 03:02"), Content = "strach sie bac." };

            var post2_comm1 = new Comment { User = janusz, Post = post2, Datetime = DateTime.Parse("2019-01-15 02:02"), Content = "Fajnie." };
            var post2_comm2 = new Comment { User = michal, Post = post2, Datetime = DateTime.Parse("2019-01-16 13:34"), Content = "Mi sie nie podoba" };
            var post2_comm3 = new Comment { User = bartek, Post = post2, Datetime = DateTime.Parse("2019-01-20 15:02"), Content = "strach sie bac." };

            var post3_comm1 = new Comment { User = bartek, Post = post3, Datetime = DateTime.Parse("2019-01-18 07:02"), Content = "Fajnie." };
            var post3_comm2 = new Comment { User = bartek, Post = post3, Datetime = DateTime.Parse("2019-01-19 14:18"), Content = "Mi sie nie podoba" };
            var post3_comm3 = new Comment { User = janusz, Post = post3, Datetime = DateTime.Parse("2019-01-21 19:02"), Content = "strach sie bac." };

            var post4_comm1 = new Comment { User = michal, Post = post4, Datetime = DateTime.Parse("2019-01-15 12:22"), Content = "Fajnie." };
            var post4_comm2 = new Comment { User = michal, Post = post4, Datetime = DateTime.Parse("2019-01-16 23:54"), Content = "Mi sie nie podoba" };
            var post4_comm3 = new Comment { User = janusz, Post = post4, Datetime = DateTime.Parse("2019-01-19 13:02"), Content = "strach sie bac." };
            #endregion
            var listComment = new List<Comment>
            {
                post1_comm1, post1_comm2, post1_comm3,
                post2_comm1, post2_comm2, post2_comm3,
                post3_comm1, post3_comm2, post3_comm3,
                post4_comm1, post4_comm2, post4_comm3
            };
            listComment.ForEach(comm => context.Comments.Add(comm));


            // eventy
            var event1 = new Event { Group = ug_mfi_g1, User = janusz, Datetime = DateTime.Parse("2019-01-18 07:02"), EventType = EventType.kolokwium, Description = "Kolo z grafuf" };
            var event2 = new Event { Group = ug_mfi_g1, User = janusz, Datetime = DateTime.Parse("2019-01-18 07:02"), EventType = EventType.egzamin, Description = "Kolo z grafuf" };
            var event3 = new Event { Group = ug_mfi_g2, User = janusz, Datetime = DateTime.Parse("2019-01-18 07:02"), EventType = EventType.spotkanie, Description = "Kolo z grafuf" };
            var event4 = new Event { Group = ug_mfi_g2, User = janusz, Datetime = DateTime.Parse("2019-01-18 07:02"), EventType = EventType.inne, Description = "Kolo z grafuf" };
            var listEvent = new List<Event>
            {
                event1, event2, event3, event4
            };
            listEvent.ForEach(evnt => context.Events.Add(evnt));


            // zapisz zmiany
            context.SaveChanges();

        }
    }
}