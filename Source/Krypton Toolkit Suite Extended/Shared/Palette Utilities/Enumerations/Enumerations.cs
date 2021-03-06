﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton.Toolkit.Extended.Palette.Utilities
{
    public enum PaletteColours
    {
        TEXTLABELCONTROL = 0,
        TEXTBUTTONNORMAL = 1,
        TEXTBUTTONCHECKED = 2,
        BUTTONNORMALBORDER = 3,
        BUTTONNORMALDEFAULTBORDER = 4,
        BUTTONNORMALBACK1 = 5,
        BUTTONNORMALBACK2 = 6,
        BUTTONNORMALDEFAULTBACK1 = 7,
        BUTTONNORMALDEFAULTBACK2 = 8,
        BUTTONNORMALNAVIGATORBACK1 = 9,
        BUTTONNORMALNAVIGATORBACK2 = 10,
        PANELCLIENT = 11,
        PANELALTERNATIVE = 12,
        CONTROLBORDER = 13,
        SEPARATORHIGHBORDER1 = 14,
        SEPARATORHIGHBORDER2 = 15,
        HEADERPRIMARYBACK1 = 16,
        HEADERPRIMARYBACK2 = 17,
        HEADERSECONDARYBACK1 = 18,
        HEADERSECONDARYBACK2 = 19,
        HEADERTEXT = 20,
        STATUSSTRIPTEXT = 21,
        BUTTONBORDER = 22,
        SEPARATORLIGHT = 23,
        SEPARATORDARK = 24,
        GRIPLIGHT = 25,
        GRIPDARK = 26,
        TOOLSTRIPBACK = 27,
        STATUSSTRIPLIGHT = 28,
        STATUSSTRIPDARK = 29,
        IMAGEMARGIN = 30,
        TOOLSTRIPBEGIN = 31,
        TOOLSTRIPMIDDLE = 32,
        TOOLSTRIPEND = 33,
        OVERFLOWBEGIN = 34,
        OVERFLOWMIDDLE = 35,
        OVERFLOWEND = 36,
        TOOLSTRIPBORDER = 37,
        FORMBORDERACTIVE = 38,
        FORMBORDERINACTIVE = 39,
        FORMBORDERACTIVELIGHT = 40,
        FORMBORDERACTIVEDARK = 41,
        FORMBORDERINACTIVELIGHT = 42,
        FORMBORDERINACTIVEDARK = 43,
        FORMBORDERHEADERACTIVE = 44,
        FORMBORDERHEADERINACTIVE = 45,
        FORMBORDERHEADERACTIVE1 = 46,
        FORMBORDERHEADERACTIVE2 = 47,
        FORMBORDERHEADERINACTIVE1 = 48,
        FORMBORDERHEADERINACTIVE2 = 49,
        FORMHEADERSHORTACTIVE = 50,
        FORMHEADERSHORTINACTIVE = 51,
        FORMHEADERLONGACTIVE = 52,
        FORMHEADERLONGINACTIVE = 53,
        FORMBUTTONBORDERTRACK = 54,
        FORMBUTTONBACK1TRACK = 55,
        FORMBUTTONBACK2TRACK = 56,
        FORMBUTTONBORDERPRESSED = 57,
        FORMBUTTONBACK1PRESSED = 58,
        FORMBUTTONBACK2PRESSED = 59,
        TEXTBUTTONFORMNORMAL = 60,
        TEXTBUTTONFORMTRACKING = 61,
        TEXTBUTTONFORMPRESSED = 62,
        LINKNOTVISITEDOVERRIDECONTROL = 63,
        LINKVISITEDOVERRIDECONTROL = 64,
        LINKPRESSEDOVERRIDECONTROL = 65,
        LINKNOTVISITEDOVERRIDEPANEL = 66,
        LINKVISITEDOVERRIDEPANEL = 67,
        LINKPRESSEDOVERRIDEPANEL = 68,
        TEXTLABELPANEL = 69,
        RIBBONTABTEXTNORMAL = 70,
        RIBBONTABTEXTCHECKED = 71,
        RIBBONTABSELECTED1 = 72,
        RIBBONTABSELECTED2 = 73,
        RIBBONTABSELECTED3 = 74,
        RIBBONTABSELECTED4 = 75,
        RIBBONTABSELECTED5 = 76,
        RIBBONTABTRACKING1 = 77,
        RIBBONTABTRACKING2 = 78,
        RIBBONTABHIGHLIGHT1 = 79,
        RIBBONTABHIGHLIGHT2 = 80,
        RIBBONTABHIGHLIGHT3 = 81,
        RIBBONTABHIGHLIGHT4 = 82,
        RIBBONTABHIGHLIGHT5 = 83,
        RIBBONTABSEPARATORCOLOR = 84,
        RIBBONGROUPSAREA1 = 85,
        RIBBONGROUPSAREA2 = 86,
        RIBBONGROUPSAREA3 = 87,
        RIBBONGROUPSAREA4 = 88,
        RIBBONGROUPSAREA5 = 89,
        RIBBONGROUPBORDER1 = 90,
        RIBBONGROUPBORDER2 = 91,
        RIBBONGROUPTITLE1 = 92,
        RIBBONGROUPTITLE2 = 93,
        RIBBONGROUPBORDERCONTEXT1 = 94,
        RIBBONGROUPBORDERCONTEXT2 = 95,
        RIBBONGROUPTITLECONTEXT1 = 96,
        RIBBONGROUPTITLECONTEXT2 = 97,
        RIBBONGROUPDIALOGDARK = 98,
        RIBBONGROUPDIALOGLIGHT = 99,
        RIBBONGROUPTITLETRACKING1 = 100,
        RIBBONGROUPTITLETRACKING2 = 101,
        RIBBONMINIMIZEBARDARK = 102,
        RIBBONMINIMIZEBARLIGHT = 103,
        RIBBONGROUPCOLLAPSEDBORDER1 = 104,
        RIBBONGROUPCOLLAPSEDBORDER2 = 105,
        RIBBONGROUPCOLLAPSEDBORDER3 = 106,
        RIBBONGROUPCOLLAPSEDBORDER4 = 107,
        RIBBONGROUPCOLLAPSEDBACK1 = 108,
        RIBBONGROUPCOLLAPSEDBACK2 = 109,
        RIBBONGROUPCOLLAPSEDBACK3 = 110,
        RIBBONGROUPCOLLAPSEDBACK4 = 111,
        RIBBONGROUPCOLLAPSEDBORDERT1 = 112,
        RIBBONGROUPCOLLAPSEDBORDERT2 = 113,
        RIBBONGROUPCOLLAPSEDBORDERT3 = 114,
        RIBBONGROUPCOLLAPSEDBORDERT4 = 115,
        RIBBONGROUPCOLLAPSEDBACKT1 = 116,
        RIBBONGROUPCOLLAPSEDBACKT2 = 117,
        RIBBONGROUPCOLLAPSEDBACKT3 = 118,
        RIBBONGROUPCOLLAPSEDBACKT4 = 119,
        RIBBONGROUPFRAMEBORDER1 = 120,
        RIBBONGROUPFRAMEBORDER2 = 121,
        RIBBONGROUPFRAMEINSIDE1 = 122,
        RIBBONGROUPFRAMEINSIDE2 = 123,
        RIBBONGROUPFRAMEINSIDE3 = 124,
        RIBBONGROUPFRAMEINSIDE4 = 125,
        RIBBONGROUPCOLLAPSEDTEXT = 126,
        ALTERNATEPRESSEDBACK1 = 127,
        ALTERNATEPRESSEDBACK2 = 128,
        ALTERNATEPRESSEDBORDER1 = 129,
        ALTERNATEPRESSEDBORDER2 = 130,
        FORMBUTTONBACK1CHECKED = 131,
        FORMBUTTONBACK2CHECKED = 132,
        FORMBUTTONBORDERCHECK = 133,
        FORMBUTTONBACK1CHECKTRACK = 134,
        FORMBUTTONBACK2CHECKTRACK = 135,
        RIBBONQATMINI1 = 136,
        RIBBONQATMINI2 = 137,
        RIBBONQATMINI3 = 138,
        RIBBONQATMINI4 = 139,
        RIBBONQATMINI5 = 140,
        RIBBONQATMINI1I = 141,
        RIBBONQATMINI2I = 142,
        RIBBONQATMINI3I = 143,
        RIBBONQATMINI4I = 144,
        RIBBONQATMINI5I = 145,
        RIBBONQATFULLBAR1 = 146,
        RIBBONQATFULLBAR2 = 147,
        RIBBONQATFULLBAR3 = 148,
        RIBBONQATBUTTONDARK = 149,
        RIBBONQATBUTTONLIGHT = 150,
        RIBBONQATOVERFLOW1 = 151,
        RIBBONQATOVERFLOW2 = 152,
        RIBBONGROUPSEPARATORDARK = 153,
        RIBBONGROUPSEPARATORLIGHT = 154,
        BUTTONCLUSTERBUTTONBACK1 = 155,
        BUTTONCLUSTERBUTTONBACK2 = 156,
        BUTTONCLUSTERBUTTONBORDER1 = 157,
        BUTTONCLUSTERBUTTONBORDER2 = 158,
        NAVIGATORMINIBACKCOLOR = 159,
        GRIDLISTNORMAL1 = 160,
        GRIDLISTNORMAL2 = 161,
        GRIDLISTPRESSED1 = 162,
        GRIDLISTPRESSED2 = 163,
        GRIDLISTSELECTED = 164,
        GRIDSHEETCOLNORMAL1 = 165,
        GRIDSHEETCOLNORMAL2 = 166,
        GRIDSHEETCOLPRESSED1 = 167,
        GRIDSHEETCOLPRESSED2 = 168,
        GRIDSHEETCOLSELECTED1 = 169,
        GRIDSHEETCOLSELECTED2 = 170,
        GRIDSHEETROWNORMAL = 171,
        GRIDSHEETROWPRESSED = 172,
        GRIDSHEETROWSELECTED = 173,
        GRIDDATACELLBORDER = 174,
        GRIDDATACELLSELECTED = 175,
        INPUTCONTROLTEXTNORMAL = 176,
        INPUTCONTROLTEXTDISABLED = 177,
        INPUTCONTROLBORDERNORMAL = 178,
        INPUTCONTROLBORDERDISABLED = 179,
        INPUTCONTROLBACKNORMAL = 180,
        INPUTCONTROLBACKDISABLED = 181,
        INPUTCONTROLBACKINACTIVE = 182,
        INPUTDROPDOWNNORMAL1 = 183,
        INPUTDROPDOWNNORMAL2 = 184,
        INPUTDROPDOWNDISABLED1 = 185,
        INPUTDROPDOWNDISABLED2 = 186,
        CONTEXTMENUHEADINGBACK = 187,
        CONTEXTMENUHEADINGTEXT = 188,
        CONTEXTMENUIMAGECOLUMN = 189,
        APPBUTTONBACK1 = 190,
        APPBUTTONBACK2 = 191,
        APPBUTTONBORDER = 192,
        APPBUTTONOUTER1 = 193,
        APPBUTTONOUTER2 = 194,
        APPBUTTONOUTER3 = 195,
        APPBUTTONINNER1 = 196,
        APPBUTTONINNER2 = 197,
        APPBUTTONMENUDOCSBACK = 198,
        APPBUTTONMENUDOCSTEXT = 199,
        SEPARATORHIGHINTERNALBORDER1 = 200,
        SEPARATORHIGHINTERNALBORDER2 = 201,
        RIBBONGALLERYBORDER = 202,
        RIBBONGALLERYBACKNORMAL = 203,
        RIBBONGALLERYBACKTRACKING = 204,
        RIBBONGALLERYBACK1 = 205,
        RIBBONGALLERYBACK2 = 206,
        RIBBONTABTRACKING3 = 207,
        RIBBONTABTRACKING4 = 208,
        RIBBONGROUPBORDER3 = 209,
        RIBBONGROUPBORDER4 = 210,
        RIBBONGROUPBORDER5 = 211,
        RIBBONGROUPTITLETEXT = 212,
        RIBBONDROPARROWLIGHT = 213,
        RIBBONDROPARROWDARK = 214,
        HEADERDOCKINACTIVEBACK1 = 215,
        HEADERDOCKINACTIVEBACK2 = 216,
        BUTTONNAVIGATORBORDER = 217,
        BUTTONNAVIGATORTEXT = 218,
        BUTTONNAVIGATORTRACK1 = 219,
        BUTTONNAVIGATORTRACK2 = 220,
        BUTTONNAVIGATORPRESSED1 = 221,
        BUTTONNAVIGATORPRESSED2 = 222,
        BUTTONNAVIGATORCHECKED1 = 223,
        BUTTONNAVIGATORCHECKED2 = 224,
        TOOLTIPBOTTOM = 225,
    }
}