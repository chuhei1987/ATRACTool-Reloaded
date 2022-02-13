﻿namespace ATRACTool_Reloaded
{
    public partial class FormSettings : Form
    {
        private string bitrateAT3 = null!;
        private string wholeloopAT3 = null!;
        private string looppointAT3 = null!;
        private string loopstartAT3 = null!;
        private string loopendAT3 = null!;
        private string looptimeAT3 = null!;
        private string looptimesAT3 = null!;
        private string paramAT3 = "at3tool -e";

        private string bitrateAT9 = null!;
        private string samplingAT9 = null!;
        private string wholeloopAT9 = null!;
        private string looppointAT9 = null!;
        private string loopstartAT9 = null!;
        private string loopendAT9 = null!;
        private string looptimeAT9 = null!;
        private string looptimesAT9 = null!;
        private string looplistAT9 = null!;
        private string looplistfileAT9 = null!;
        private string enctypeAT9 = null!;
        private string dualencAT9 = null!;
        private string supframeAT9 = null!;
        private string nbandAT9 = null!;
        private string isbandAT9 = null!;
        private string paramAT9 = "at9tool -e";

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            Common.IniFile ini = new(@".\settings.ini");
            int bitrateindexAT3 = ini.GetInt("ATRAC3_SETTINGS", "Bitrate", 65535),
                bitrateindexAT9 = ini.GetInt("ATRAC9_SETTINGS", "Bitrate", 65535),
                looppointindexAT3 = ini.GetInt("ATRAC3_SETTINGS", "LoopPoint", 65535),
                looppointindexAT9 = ini.GetInt("ATRAC9_SETTINGS", "LoopPoint", 65535),
                wholeloopindexAT3 = ini.GetInt("ATRAC3_SETTINGS", "LoopSound", 65535),
                wholeloopindexAT9 = ini.GetInt("ATRAC9_SETTINGS", "LoopSound", 65535),
                looptimeindexAT3 = ini.GetInt("ATRAC3_SETTINGS", "LoopTime", 65535),
                looptimeindexAT9 = ini.GetInt("ATRAC9_SETTINGS", "LoopTime", 65535),
                looplistindex = ini.GetInt("ATRAC9_SETTINGS", "LoopList", 65535),
                samplingindex = ini.GetInt("ATRAC9_SETTINGS", "Sampling", 65535),
                advancedindex = ini.GetInt("ATRAC9_SETTINGS", "Advanced", 65535),
                enctypeindex = ini.GetInt("ATRAC9_SETTINGS", "EncodeType", 65535),
                encindex = ini.GetInt("ATRAC9_SETTINGS", "EncodeTypeIndex", 65535),
                dualencindex = ini.GetInt("ATRAC9_SETTINGS", "DualEncode", 65535),
                supframeindex = ini.GetInt("ATRAC9_SETTINGS", "SuperFrameEncode", 65535),
                advbandindex = ini.GetInt("ATRAC9_SETTINGS", "AdvancedBand", 65535),
                nband = ini.GetInt("ATRAC9_SETTINGS", "NbandsIndex", 65535),
                isband = ini.GetInt("ATRAC9_SETTINGS", "IsbandIndex", 65535);
            string loopstartindexAT3 = ini.GetString("ATRAC3_SETTINGS", "LoopStart_Samples", ""),
                loopstartindexAT9 = ini.GetString("ATRAC9_SETTINGS", "LoopStart_Samples", ""),
                loopendindexAT3 = ini.GetString("ATRAC3_SETTINGS", "LoopEnd_Samples", ""),
                loopendindexAT9 = ini.GetString("ATRAC9_SETTINGS", "LoopStart_Samples", ""),
                looptimesindexAT3 = ini.GetString("ATRAC3_SETTINGS", "LoopTimes", ""),
                looptimesindexAT9 = ini.GetString("ATRAC9_SETTINGS", "LoopTimes", ""),
                looplistfile = ini.GetString("ATRAC9_SETTINGS", "LoopListFile", ""),
                prmAT3 = ini.GetString("ATRAC3_SETTINGS", "Param", ""),
                prmAT9 = ini.GetString("ATRAC9_SETTINGS", "Param", "");

            comboBox_at9_enctype.SelectedIndex = 5;
            comboBox_at9_startband.SelectedIndex = 0;
            comboBox_at9_useband.SelectedIndex = 0;

            switch (bitrateindexAT3)
            {
                case 0: // 32k
                    comboBox_at3_encmethod.SelectedIndex = 0;
                    bitrateAT3 = " -br 32";
                    break;
                case 1: // 48k
                    comboBox_at3_encmethod.SelectedIndex = 1;
                    bitrateAT3 = " -br 48";
                    break;
                case 2: // 57k
                    comboBox_at3_encmethod.SelectedIndex = 2;
                    bitrateAT3 = " -br 57";
                    break;
                case 3: // 64k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 3;
                    bitrateAT3 = " -br 64";
                    break;
                case 4: // 72k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 4;
                    bitrateAT3 = " -br 72";
                    break;
                case 5: // 96k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 5;
                    bitrateAT3 = " -br 96";
                    break;
                case 6: // 114k stereo
                    comboBox_at3_encmethod.SelectedIndex = 6;
                    bitrateAT3 = " -br 114";
                    break;
                case 7: // 128k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 7;
                    bitrateAT3 = " -br 128";
                    break;
                case 8: // 144k
                    comboBox_at3_encmethod.SelectedIndex = 8;
                    bitrateAT3 = " -br 144";
                    break;
                case 9: // 160k
                    comboBox_at3_encmethod.SelectedIndex = 9;
                    bitrateAT3 = " -br 160";
                    break;
                case 10: // 192k
                    comboBox_at3_encmethod.SelectedIndex = 10;
                    bitrateAT3 = " -br 192";
                    break;
                case 11: // 256k
                    comboBox_at3_encmethod.SelectedIndex = 11;
                    bitrateAT3 = " -br 256";
                    break;
                case 12: // 320k
                    comboBox_at3_encmethod.SelectedIndex = 12;
                    bitrateAT3 = " -br 320";
                    break;
                case 13: // 384k
                    comboBox_at3_encmethod.SelectedIndex = 13;
                    bitrateAT3 = " -br 384";
                    break;
                case 14: // 512k
                    comboBox_at3_encmethod.SelectedIndex = 14;
                    bitrateAT3 = " -br 512";
                    break;
                case 15: // 768k
                    comboBox_at3_encmethod.SelectedIndex = 15;
                    bitrateAT3 = " -br 768";
                    break;
                default:
                    comboBox_at3_encmethod.SelectedIndex = 10;
                    bitrateAT3 = " -br 192";
                    break;
            }
            switch (bitrateindexAT9)
            {
                case 0:
                    comboBox_at9_bitrate.SelectedIndex = 0;
                    bitrateAT9 = " -br 36";
                    break;
                case 1:
                    comboBox_at9_bitrate.SelectedIndex = 1;
                    bitrateAT9 = " -br 48";
                    break;
                case 2:
                    comboBox_at9_bitrate.SelectedIndex = 2;
                    bitrateAT9 = " -br 60";
                    break;
                case 3:
                    comboBox_at9_bitrate.SelectedIndex = 3;
                    bitrateAT9 = " -br 72";
                    break;
                case 4:
                    comboBox_at9_bitrate.SelectedIndex = 4;
                    bitrateAT9 = " -br 84";
                    break;
                case 5:
                    comboBox_at9_bitrate.SelectedIndex = 5;
                    bitrateAT9 = " -br 96";
                    break;
                case 6:
                    comboBox_at9_bitrate.SelectedIndex = 6;
                    bitrateAT9 = " -br 120";
                    break;
                case 7:
                    comboBox_at9_bitrate.SelectedIndex = 7;
                    bitrateAT9 = " -br 144";
                    break;
                case 8:
                    comboBox_at9_bitrate.SelectedIndex = 8;
                    bitrateAT9 = " -br 168";
                    break;
                default:
                    comboBox_at9_bitrate.SelectedIndex = 8;
                    bitrateAT9 = " -br 168";
                    break;
            }

            switch (samplingindex)
            {
                case 0:
                    comboBox_at9_sampling.SelectedIndex = 0;
                    samplingAT9 = " -fs 12000";
                    break;
                case 1:
                    comboBox_at9_sampling.SelectedIndex = 1;
                    samplingAT9 = " -fs 24000";
                    break;
                case 2:
                    comboBox_at9_sampling.SelectedIndex = 2;
                    samplingAT9 = " -fs 48000";
                    break;
                default:
                    comboBox_at9_sampling.SelectedIndex = 2;
                    samplingAT9 = " -fs 48000";
                    break;
            }

            if (looppointindexAT3 != 65535)
            {
                if (looppointindexAT3 != 0)
                {
                    wholeloopAT3 = "";
                    checkBox_at3_loopsound.Enabled = false;

                    checkBox_at3_looppoint.Checked = true;
                    looppointAT3 = " -loop";
                    label_at3_loopstart.Enabled = true;
                    label_at3_loopend.Enabled = true;
                    label_at3_samples.Enabled = true;
                    textBox_at3_loopstart.Enabled = true;
                    textBox_at3_loopend.Enabled = true;
                    if (loopstartindexAT3 != "")
                    {
                        loopstartAT3 = loopstartindexAT3;
                        textBox_at3_loopstart.Text = loopstartAT3;
                    }
                    if (loopendindexAT3 != "")
                    {
                        loopendAT3 = loopendindexAT3;
                        textBox_at3_loopend.Text = loopendAT3;
                    }
                }
                else
                {
                    checkBox_at3_loopsound.Enabled = true;

                    looppointAT3 = "";
                    loopstartAT3 = "";
                    loopendAT3 = "";
                    checkBox_at3_looppoint.Checked = false;
                    label_at3_loopstart.Enabled = false;
                    label_at3_loopend.Enabled = false;
                    label_at3_samples.Enabled = false;
                    textBox_at3_loopstart.Enabled = false;
                    textBox_at3_loopstart.Text = null;
                    textBox_at3_loopend.Enabled = false;
                    textBox_at3_loopend.Text = null;
                }
            }
            else
            {
                checkBox_at3_loopsound.Enabled = true;

                looppointAT3 = "";
                loopstartAT3 = "";
                loopendAT3 = "";
                checkBox_at3_looppoint.Checked = false;
                label_at3_loopstart.Enabled = false;
                label_at3_loopend.Enabled = false;
                label_at3_samples.Enabled = false;
                textBox_at3_loopstart.Enabled = false;
                textBox_at3_loopstart.Text = null;
                textBox_at3_loopend.Enabled = false;
                textBox_at3_loopend.Text = null;
            }

            if (looppointindexAT9 != 65535)
            {
                if (looppointindexAT9 != 0)
                {
                    checkBox_at9_loopsound.Enabled = false;
                    checkBox_at9_looppoint.Checked = true;
                    looppointAT9 = " -loop";
                    label_at9_loopstart.Enabled = true;
                    label_at9_loopend.Enabled = true;
                    label_at9_samples.Enabled = true;
                    textBox_at9_loopstart.Enabled = true;
                    textBox_at9_loopend.Enabled = true;
                    if (loopstartindexAT9 != "")
                    {
                        loopstartAT9 = loopstartindexAT9;
                        textBox_at9_loopstart.Text = loopstartAT9;
                    }
                    if (loopendindexAT9 != "")
                    {
                        loopendAT9 = loopendindexAT9;
                        textBox_at9_loopend.Text = loopendAT9;
                    }
                }
                else
                {
                    looppointAT9 = "";
                    loopstartAT9 = "";
                    loopendAT9 = "";
                    checkBox_at9_looppoint.Checked = false;
                    label_at9_loopstart.Enabled = false;
                    label_at9_loopend.Enabled = false;
                    label_at9_samples.Enabled = false;
                    textBox_at9_loopstart.Enabled = false;
                    textBox_at9_loopstart.Text = null;
                    textBox_at9_loopend.Enabled = false;
                    textBox_at9_loopend.Text = null;
                    checkBox_at9_loopsound.Enabled = true;
                }
            }
            else
            {
                looppointAT9 = "";
                loopstartAT9 = "";
                loopendAT9 = "";
                checkBox_at9_looppoint.Checked = false;
                label_at9_loopstart.Enabled = false;
                label_at9_loopend.Enabled = false;
                label_at9_samples.Enabled = false;
                textBox_at9_loopstart.Enabled = false;
                textBox_at9_loopstart.Text = null;
                textBox_at9_loopend.Enabled = false;
                textBox_at9_loopend.Text = null;
                checkBox_at9_loopsound.Enabled = true;
            }

            if (wholeloopindexAT3 != 65535)
            {
                if (wholeloopindexAT3 != 0)
                {
                    wholeloopAT3 = " -wholeloop";
                    checkBox_at3_loopsound.Checked = true;
                    checkBox_at3_looppoint.Enabled = false;
                }
                else
                {
                    wholeloopAT3 = "";
                    checkBox_at3_loopsound.Checked = false;
                    checkBox_at3_looppoint.Enabled = true;
                }
            }
            else
            {
                wholeloopAT3 = "";
                checkBox_at3_loopsound.Checked = false;
                checkBox_at3_looppoint.Enabled = true;
            }

            if (wholeloopindexAT9 != 65535)
            {
                if (wholeloopindexAT9 != 0)
                {
                    wholeloopAT9 = " -wholeloop";
                    checkBox_at9_loopsound.Checked = true;
                    checkBox_at9_looppoint.Enabled = false;
                }
                else
                {
                    wholeloopAT9 = "";
                    checkBox_at9_loopsound.Checked = false;
                    checkBox_at9_looppoint.Enabled = true;
                }
            }
            else
            {
                wholeloopAT9 = "";
                checkBox_at9_loopsound.Checked = false;
                checkBox_at9_looppoint.Enabled = true;
            }

            if (looptimeindexAT3 != 65535)
            {
                if (looptimeindexAT3 != 0)
                {
                    if (looptimesindexAT3 != "")
                    {
                        checkBox_at3_looptimes.Checked = true;
                        looptimeAT3 = " -repeat";
                        label_at3_nol.Enabled = true;
                        label_at3_times.Enabled = true;
                        textBox_at3_looptimes.Enabled = true;
                        textBox_at3_looptimes.Text = looptimesindexAT3;
                    }
                    else
                    {
                        checkBox_at3_looptimes.Checked = true;
                        looptimeAT3 = " -repeat";
                        label_at3_nol.Enabled = true;
                        label_at3_times.Enabled = true;
                        textBox_at3_looptimes.Enabled = true;
                        textBox_at3_looptimes.Text = looptimesindexAT3;
                    }
                }
                else
                {
                    looptimeAT3 = "";
                    looptimesAT3 = "";
                    checkBox_at3_looptimes.Checked = false;
                    label_at3_nol.Enabled = false;
                    label_at3_times.Enabled = false;
                    textBox_at3_looptimes.Enabled = false;
                    textBox_at3_looptimes.Text = null;
                }
            }
            else
            {
                looptimeAT3 = "";
                looptimesAT3 = "";
                checkBox_at3_looptimes.Checked = false;
                label_at3_nol.Enabled = false;
                label_at3_times.Enabled = false;
                textBox_at3_looptimes.Enabled = false;
                textBox_at3_looptimes.Text = null;
            }

            if (looptimeindexAT9 != 65535)
            {
                if (looptimeindexAT9 != 0)
                {
                    if (looptimesindexAT9 != "")
                    {
                        checkBox_at9_looptimes.Checked = true;
                        looptimeAT9 = " -repeat";
                        label_at9_nol.Enabled = true;
                        label_at9_times.Enabled = true;
                        textBox_at9_looptimes.Enabled = true;
                        textBox_at9_looptimes.Text = looptimesindexAT3;
                    }
                    else
                    {
                        checkBox_at9_looptimes.Checked = true;
                        looptimeAT9 = " -repeat";
                        label_at9_nol.Enabled = true;
                        label_at9_times.Enabled = true;
                        textBox_at9_looptimes.Enabled = true;
                        textBox_at9_looptimes.Text = looptimesindexAT3;
                    }
                }
                else
                {
                    looptimeAT9 = "";
                    looptimesAT9 = "";
                    checkBox_at9_looptimes.Checked = false;
                    label_at9_nol.Enabled = false;
                    label_at9_times.Enabled = false;
                    textBox_at9_looptimes.Enabled = false;
                    textBox_at9_looptimes.Text = null;
                }
            }
            else
            {
                looptimeAT9 = "";
                looptimesAT9 = "";
                checkBox_at9_looptimes.Checked = false;
                label_at9_nol.Enabled = false;
                label_at9_times.Enabled = false;
                textBox_at9_looptimes.Enabled = false;
                textBox_at9_looptimes.Text = null;
            }

            if (looplistindex != 65535)
            {
                if (looplistindex != 0)
                {
                    checkBox_at9_looplist.Checked = true;
                    looplistAT9 = " -looplist";
                    textBox_at9_looplist.Enabled = true;
                    button_at9_looplist.Enabled = true;
                    if (looplistfile != "")
                    {
                        textBox_at9_looplist.Text = looplistfile;
                    }
                    else
                    {
                        textBox_at9_looplist.Text = "";
                    }
                }
                else
                {
                    checkBox_at9_looplist.Checked = false;
                    looplistAT9 = "";
                    textBox_at9_looplist.Enabled = false;
                    textBox_at9_looplist.Text = null;
                    button_at9_looplist.Enabled = false;
                }
            }
            else
            {
                checkBox_at9_looplist.Checked = false;
                looplistAT9 = "";
                textBox_at9_looplist.Enabled = false;
                textBox_at9_looplist.Text = null;
                button_at9_looplist.Enabled = false;
            }

            if (advancedindex != 65535)
            {
                if (advancedindex != 0)
                {
                    checkBox_at9_enctype.Enabled = true;
                    checkBox_at9_advband.Enabled = true;
                    checkBox_at9_dualenc.Enabled = true;
                    checkBox_at9_supframe.Enabled = true;
                    if (enctypeindex != 65535)
                    {
                        if (enctypeindex != 0)
                        {
                            checkBox_at9_enctype.Checked = true;
                        }
                        else
                        {
                            checkBox_at9_enctype.Checked = false;
                        }
                    }
                    if (encindex != 65535)
                    {
                        if (encindex != 0)
                        {
                            switch (encindex)
                            {
                                case 0:
                                    comboBox_at9_enctype.SelectedIndex = 0;
                                    enctypeAT9 = " -gradmode 0";
                                    break;
                                case 1:
                                    comboBox_at9_enctype.SelectedIndex = 1;
                                    enctypeAT9 = " -gradmode 1";
                                    break;
                                case 2:
                                    comboBox_at9_enctype.SelectedIndex = 2;
                                    enctypeAT9 = " -gradmode 2";
                                    break;
                                case 3:
                                    comboBox_at9_enctype.SelectedIndex = 3;
                                    enctypeAT9 = " -gradmode 3";
                                    break;
                                case 4:
                                    comboBox_at9_enctype.SelectedIndex = 4;
                                    enctypeAT9 = " -gradmode 4";
                                    break;
                                case 5:
                                    comboBox_at9_enctype.SelectedIndex = 5;
                                    enctypeAT9 = "";
                                    break;
                                default:
                                    comboBox_at9_enctype.SelectedIndex = 5;
                                    enctypeAT9 = "";
                                    break;
                            }
                        }
                        else
                        {
                            comboBox_at9_enctype.SelectedIndex = 5;
                            enctypeAT9 = "";
                        }
                    }
                    else
                    {
                        comboBox_at9_enctype.SelectedIndex = 5;
                        enctypeAT9 = "";
                    }
                    if (dualencindex != 65535)
                    {
                        if (dualencindex != 0)
                        {
                            checkBox_at9_dualenc.Checked = true;
                            dualencAT9 = " -dual";
                        }
                        else
                        {
                            checkBox_at9_dualenc.Checked = false;
                            dualencAT9 = "";
                        }
                    }
                    else
                    {
                        checkBox_at9_dualenc.Checked = false;
                        dualencAT9 = "";
                    }
                    if (supframeindex != 65535)
                    {
                        if (supframeindex != 0)
                        {
                            checkBox_at9_supframe.Checked = true;
                            supframeAT9 = " -supframeon";
                        }
                        else
                        {
                            checkBox_at9_supframe.Checked = false;
                            supframeAT9 = " -supframeoff";
                        }
                    }
                    else
                    {
                        checkBox_at9_supframe.Checked = false;
                        supframeAT9 = " -supframeoff";
                    }
                    if (advbandindex != 65535)
                    {
                        if (advbandindex != 0)
                        {
                            checkBox_at9_advband.Checked = true;
                            label_at9_useband.Enabled = true;
                            comboBox_at9_useband.Enabled = true;
                            label_at9_startband.Enabled = true;
                            comboBox_at9_startband.Enabled = true;
                            if (nband != 65535)
                            {
                                if (nband != 0)
                                {
                                    switch (nband)
                                    {
                                        case 0:
                                            comboBox_at9_useband.SelectedIndex = 0;
                                            nbandAT9 = " -nbands 3";
                                            break;
                                        case 1:
                                            comboBox_at9_useband.SelectedIndex = 1;
                                            nbandAT9 = " -nbands 4";
                                            break;
                                        case 2:
                                            comboBox_at9_useband.SelectedIndex = 2;
                                            nbandAT9 = " -nbands 5";
                                            break;
                                        case 3:
                                            comboBox_at9_useband.SelectedIndex = 3;
                                            nbandAT9 = " -nbands 6";
                                            break;
                                        case 4:
                                            comboBox_at9_useband.SelectedIndex = 4;
                                            nbandAT9 = " -nbands 7";
                                            break;
                                        case 5:
                                            comboBox_at9_useband.SelectedIndex = 5;
                                            nbandAT9 = " -nbands 8";
                                            break;
                                        case 6:
                                            comboBox_at9_useband.SelectedIndex = 6;
                                            nbandAT9 = " -nbands 9";
                                            break;
                                        case 7:
                                            comboBox_at9_useband.SelectedIndex = 7;
                                            nbandAT9 = " -nbands 10";
                                            break;
                                        case 8:
                                            comboBox_at9_useband.SelectedIndex = 8;
                                            nbandAT9 = " -nbands 11";
                                            break;
                                        case 9:
                                            comboBox_at9_useband.SelectedIndex = 9;
                                            nbandAT9 = " -nbands 12";
                                            break;
                                        case 10:
                                            comboBox_at9_useband.SelectedIndex = 10;
                                            nbandAT9 = " -nbands 13";
                                            break;
                                        case 11:
                                            comboBox_at9_useband.SelectedIndex = 11;
                                            nbandAT9 = " -nbands 14";
                                            break;
                                        case 12:
                                            comboBox_at9_useband.SelectedIndex = 12;
                                            nbandAT9 = " -nbands 15";
                                            break;
                                        case 13:
                                            comboBox_at9_useband.SelectedIndex = 13;
                                            nbandAT9 = " -nbands 16";
                                            break;
                                        case 14:
                                            comboBox_at9_useband.SelectedIndex = 14;
                                            nbandAT9 = " -nbands 17";
                                            break;
                                        case 15:
                                            comboBox_at9_useband.SelectedIndex = 15;
                                            nbandAT9 = " -nbands 18";
                                            break;
                                        default:
                                            comboBox_at9_useband.SelectedIndex = 15;
                                            nbandAT9 = "";
                                            break;
                                    }
                                }
                                else
                                {
                                    comboBox_at9_useband.SelectedIndex = 15;
                                    nbandAT9 = "";
                                }
                            }
                            else
                            {
                                comboBox_at9_useband.SelectedIndex = 15;
                                nbandAT9 = "";
                            }
                            if (isband != 65535)
                            {
                                if (isband != 0)
                                {
                                    switch (isband)
                                    {
                                        case 0:
                                            comboBox_at9_startband.SelectedIndex = 0;
                                            isbandAT9 = " -isband -1";
                                            break;
                                        case 1:
                                            comboBox_at9_startband.SelectedIndex = 1;
                                            isbandAT9 = " -isband 3";
                                            break;
                                        default:
                                            comboBox_at9_startband.SelectedIndex = 0;
                                            isbandAT9 = "";
                                            break;
                                    }
                                }
                                else
                                {
                                    comboBox_at9_startband.SelectedIndex = 0;
                                    isbandAT9 = "";
                                }
                            }
                            else
                            {
                                comboBox_at9_startband.SelectedIndex = 0;
                                isbandAT9 = "";
                            }
                        }
                        else
                        {
                            nbandAT9 = "";
                            isbandAT9 = "";
                            checkBox_at9_advband.Checked = false;
                            label_at9_useband.Enabled = false;
                            comboBox_at9_useband.Enabled = false;
                            label_at9_startband.Enabled = false;
                            comboBox_at9_startband.Enabled = false;
                        }
                    }
                    else
                    {
                        nbandAT9 = "";
                        isbandAT9 = "";
                        checkBox_at9_advband.Checked = false;
                        label_at9_useband.Enabled = false;
                        comboBox_at9_useband.Enabled = false;
                        label_at9_startband.Enabled = false;
                        comboBox_at9_startband.Enabled = false;
                    }
                }
                else
                {
                    enctypeAT9 = "";
                    nbandAT9 = "";
                    isbandAT9 = "";
                    dualencAT9 = "";
                    supframeAT9 = "";
                    checkBox_at9_enctype.Checked = false;
                    checkBox_at9_enctype.Enabled = false;
                    checkBox_at9_advband.Checked = false;
                    checkBox_at9_advband.Enabled = false;
                    checkBox_at9_dualenc.Checked = false;
                    checkBox_at9_dualenc.Enabled = false;
                    checkBox_at9_supframe.Checked = false;
                    checkBox_at9_supframe.Enabled = false;
                    comboBox_at9_enctype.Enabled = false;
                    comboBox_at9_useband.Enabled = false;
                    comboBox_at9_startband.Enabled = false;
                    label_at9_enctype.Enabled = false;
                    label_at9_startband.Enabled = false;
                    label_at9_useband.Enabled = false;
                }
            }
            else
            {
                enctypeAT9 = "";
                nbandAT9 = "";
                isbandAT9 = "";
                dualencAT9 = "";
                supframeAT9 = "";
                checkBox_at9_enctype.Checked = false;
                checkBox_at9_enctype.Enabled = false;
                checkBox_at9_advband.Checked = false;
                checkBox_at9_advband.Enabled = false;
                checkBox_at9_dualenc.Checked = false;
                checkBox_at9_dualenc.Enabled = false;
                checkBox_at9_supframe.Checked = false;
                checkBox_at9_supframe.Enabled = false;
                comboBox_at9_enctype.Enabled = false;
                comboBox_at9_useband.Enabled = false;
                comboBox_at9_startband.Enabled = false;
                label_at9_enctype.Enabled = false;
                label_at9_startband.Enabled = false;
                label_at9_useband.Enabled = false;
            }

            if (prmAT3 != "")
            {
                textBox_at3_cmd.Text = prmAT3;
                paramAT3 = prmAT3;
            }
            else
            {
                paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
                textBox_at3_cmd.Text = paramAT3;
            }
            if (prmAT9 != "")
            {
                textBox_at9_cmd.Text = prmAT9;
                paramAT9 = prmAT9;
            }
            else
            {
                paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
                textBox_at9_cmd.Text = paramAT9;
            }
        }

        // ATRAC3

        private void ComboBox_at3_encmethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_at3_encmethod.SelectedIndex)
            {
                case 0: // 32k
                    comboBox_at3_encmethod.SelectedIndex = 0;
                    bitrateAT3 = " -br 32";
                    break;
                case 1: // 48k
                    comboBox_at3_encmethod.SelectedIndex = 1;
                    bitrateAT3 = " -br 48";
                    break;
                case 2: // 57k
                    comboBox_at3_encmethod.SelectedIndex = 2;
                    bitrateAT3 = " -br 57";
                    break;
                case 3: // 64k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 3;
                    bitrateAT3 = " -br 64";
                    break;
                case 4: // 72k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 4;
                    bitrateAT3 = " -br 72";
                    break;
                case 5: // 96k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 5;
                    bitrateAT3 = " -br 96";
                    break;
                case 6: // 114k stereo
                    comboBox_at3_encmethod.SelectedIndex = 6;
                    bitrateAT3 = " -br 114";
                    break;
                case 7: // 128k mono / stereo
                    comboBox_at3_encmethod.SelectedIndex = 7;
                    bitrateAT3 = " -br 128";
                    break;
                case 8: // 144k
                    comboBox_at3_encmethod.SelectedIndex = 8;
                    bitrateAT3 = " -br 144";
                    break;
                case 9: // 160k
                    comboBox_at3_encmethod.SelectedIndex = 9;
                    bitrateAT3 = " -br 160";
                    break;
                case 10: // 192k
                    comboBox_at3_encmethod.SelectedIndex = 10;
                    bitrateAT3 = " -br 192";
                    break;
                case 11: // 256k
                    comboBox_at3_encmethod.SelectedIndex = 11;
                    bitrateAT3 = " -br 256";
                    break;
                case 12: // 320k
                    comboBox_at3_encmethod.SelectedIndex = 12;
                    bitrateAT3 = " -br 320";
                    break;
                case 13: // 384k
                    comboBox_at3_encmethod.SelectedIndex = 13;
                    bitrateAT3 = " -br 384";
                    break;
                case 14: // 512k
                    comboBox_at3_encmethod.SelectedIndex = 14;
                    bitrateAT3 = " -br 512";
                    break;
                case 15: // 768k
                    comboBox_at3_encmethod.SelectedIndex = 15;
                    bitrateAT3 = " -br 768";
                    break;
                default:
                    comboBox_at3_encmethod.SelectedIndex = 10;
                    bitrateAT3 = " -br 192";
                    break;
            }
            paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
            textBox_at3_cmd.Text = paramAT3;
        }

        private void CheckBox_at3_loopsound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at3_loopsound.Checked != false)
            {
                wholeloopAT3 = " -wholeloop";
                looppointAT3 = "";
                loopstartAT3 = "";
                loopendAT3 = "";
                checkBox_at3_looppoint.Enabled = false;
                label_at3_loopstart.Enabled = false;
                label_at3_loopend.Enabled = false;
                label_at3_samples.Enabled = false;
                textBox_at3_loopstart.Enabled = false;
                textBox_at3_loopstart.Text = null;
                textBox_at3_loopend.Enabled = false;
                textBox_at3_loopend.Text = null;
            }
            else
            {
                checkBox_at3_looppoint.Enabled = true;
                wholeloopAT3 = "";
            }
            paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
            textBox_at3_cmd.Text = paramAT3;
        }

        private void CheckBox_at3_looppoint_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at3_looppoint.Checked != false)
            {
                looppointAT3 = " -loop";
                label_at3_loopstart.Enabled = true;
                label_at3_loopend.Enabled = true;
                label_at3_samples.Enabled = true;
                textBox_at3_loopstart.Enabled = true;
                textBox_at3_loopend.Enabled = true;
                wholeloopAT3 = "";
                checkBox_at3_loopsound.Checked = false;
                checkBox_at3_loopsound.Enabled = false;
            }
            else
            {
                looppointAT3 = "";
                loopstartAT3 = "";
                loopendAT3 = "";
                label_at3_loopstart.Enabled = false;
                label_at3_loopend.Enabled = false;
                label_at3_samples.Enabled = false;
                textBox_at3_loopstart.Enabled = false;
                textBox_at3_loopstart.Text = null;
                textBox_at3_loopend.Enabled = false;
                textBox_at3_loopend.Text = null;
                checkBox_at3_loopsound.Enabled = true;
            }
            paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
            textBox_at3_cmd.Text = paramAT3;
        }

        private void TextBox_at3_loopstart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextBox_at3_loopend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextBox_at3_looptimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void CheckBox_at3_looptimes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at3_looptimes.Checked != false)
            {
                looptimeAT3 = " -repeat";
                label_at3_nol.Enabled = true;
                label_at3_times.Enabled = true;
                textBox_at3_looptimes.Enabled = true;
            }
            else
            {
                looptimeAT3 = "";
                looptimesAT3 = "";
                label_at3_nol.Enabled = false;
                label_at3_times.Enabled = false;
                textBox_at3_looptimes.Enabled = false;
                textBox_at3_looptimes.Text = null;
            }
            paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
            textBox_at3_cmd.Text = paramAT3;
        }

        private void TextBox_at3_loopstart_TextChanged(object sender, EventArgs e)
        {
            if (textBox_at3_loopstart.TextLength != 0)
            {
                loopstartAT3 = " " + textBox_at3_loopstart.Text;
            }
            else
            {
                loopstartAT3 = "";
            }
            paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
            textBox_at3_cmd.Text = paramAT3;
        }

        private void TextBox_at3_loopend_TextChanged(object sender, EventArgs e)
        {
            if (textBox_at3_loopend.TextLength != 0)
            {
                loopendAT3 = " " + textBox_at3_loopend.Text;
            }
            else
            {
                loopendAT3 = "";
            }
            paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
            textBox_at3_cmd.Text = paramAT3;
        }

        private void TextBox_at3_looptimes_TextChanged(object sender, EventArgs e)
        {
            if (textBox_at3_looptimes.TextLength != 0)
            {
                looptimesAT3 = " " + textBox_at3_looptimes.Text;
            }
            else
            {
                looptimesAT3 = "";
            }
            paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
            textBox_at3_cmd.Text = paramAT3;
        }

        private void TextBox_at3_cmd_TextChanged(object sender, EventArgs e)
        {
            paramAT3 = textBox_at3_cmd.Text;
            textBox_at3_cmd.Text = paramAT3;
        }

        // ATRAC9

        private void ComboBox_at9_bitrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_at9_bitrate.SelectedIndex)
            {
                case 0:
                    bitrateAT9 = " -br 36";
                    break;
                case 1:
                    bitrateAT9 = " -br 48";
                    break;
                case 2:
                    bitrateAT9 = " -br 60";
                    break;
                case 3:
                    bitrateAT9 = " -br 72";
                    break;
                case 4:
                    bitrateAT9 = " -br 84";
                    break;
                case 5:
                    bitrateAT9 = " -br 96";
                    break;
                case 6:
                    bitrateAT9 = " -br 120";
                    break;
                case 7:
                    bitrateAT9 = " -br 144";
                    break;
                case 8:
                    bitrateAT9 = " -br 168";
                    break;
                default:
                    bitrateAT9 = " -br 168";
                    break;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void ComboBox_at9_sampling_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_at9_sampling.SelectedIndex)
            {
                case 0:
                    samplingAT9 = " -fs 12000";
                    break;
                case 1:
                    samplingAT9 = " -fs 24000";
                    break;
                case 2:
                    samplingAT9 = " -fs 48000";
                    break;
                default:
                    samplingAT9 = " -fs 48000";
                    break;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_loopsound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_loopsound.Checked != false)
            {
                wholeloopAT9 = " -wholeloop";
                looppointAT9 = "";
                loopstartAT9 = "";
                loopendAT9 = "";
                label_at9_loopstart.Enabled = false;
                label_at9_loopend.Enabled = false;
                label_at9_samples.Enabled = false;
                textBox_at9_loopstart.Enabled = false;
                textBox_at9_loopstart.Text = null;
                textBox_at9_loopend.Enabled = false;
                textBox_at9_loopend.Text = null;
                checkBox_at9_looppoint.Checked = false;
                checkBox_at9_looppoint.Enabled = false;
            }
            else
            {
                wholeloopAT9 = "";
                checkBox_at9_looppoint.Enabled = true;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_looppoint_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_looppoint.Checked != false)
            {
                wholeloopAT9 = "";
                looppointAT9 = " -loop";
                label_at9_loopstart.Enabled = true;
                label_at9_loopend.Enabled = true;
                label_at9_samples.Enabled = true;
                textBox_at9_loopstart.Enabled = true;
                textBox_at9_loopend.Enabled = true;
                checkBox_at9_loopsound.Checked = false;
                checkBox_at9_loopsound.Enabled = false;
            }
            else
            {
                looppointAT9 = "";
                loopstartAT9 = "";
                loopendAT9 = "";
                label_at9_loopstart.Enabled = false;
                label_at9_loopend.Enabled = false;
                label_at9_samples.Enabled = false;
                textBox_at9_loopstart.Enabled = false;
                textBox_at9_loopstart.Text = null;
                textBox_at9_loopend.Enabled = false;
                textBox_at9_loopend.Text = null;
                checkBox_at9_loopsound.Enabled = true;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void TextBox_at9_loopstart_TextChanged(object sender, EventArgs e)
        {
            if (textBox_at9_loopstart.TextLength != 0)
            {
                loopstartAT9 = " " + textBox_at9_loopstart.Text;
            }
            else
            {
                loopstartAT9 = "";
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void TextBox_at9_loopend_TextChanged(object sender, EventArgs e)
        {
            if (textBox_at9_loopend.TextLength != 0)
            {
                loopendAT9 = " " + textBox_at9_loopend.Text;
            }
            else
            {
                loopendAT9 = "";
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void TextBox_at9_looptimes_TextChanged(object sender, EventArgs e)
        {
            if (textBox_at9_looptimes.TextLength != 0)
            {
                looptimesAT9 = " " + textBox_at9_looptimes.Text;
            }
            else
            {
                looptimesAT9 = "";
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void TextBox_at9_loopstart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextBox_at9_loopend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextBox_at9_looptimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void CheckBox_at9_looptimes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_looptimes.Checked != false)
            {
                looptimeAT9 = " -repeat";
                label_at9_nol.Enabled = true;
                label_at9_times.Enabled = true;
                textBox_at9_looptimes.Enabled = true;
            }
            else
            {
                looptimeAT9 = "";
                looptimesAT9 = "";
                label_at9_nol.Enabled = false;
                label_at9_times.Enabled = false;
                textBox_at9_looptimes.Enabled = false;
                textBox_at9_looptimes.Text = null;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_looplist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_looplist.Checked != false)
            {
                looplistAT9 = " -looplist";
                textBox_at9_looplist.Enabled = true;
                button_at9_looplist.Enabled = true;
            }
            else
            {
                looplistAT9 = "";
                looplistfileAT9 = "";
                textBox_at9_looplist.Enabled = false;
                textBox_at9_looplist.Text = null;
                button_at9_looplist.Enabled = false;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void Button_at9_looplist_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                FileName = "",
                InitialDirectory = "",
                Filter = Localization.ListFilters,
                FilterIndex = 11,
                Title = Localization.OpenListDialogTitle,
                Multiselect = true,
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                textBox_at9_looplist.Text = ofd.FileName;
                looplistfileAT9 = " " + ofd.FileName;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_advanced_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_advanced.Checked != false)
            {
                checkBox_at9_enctype.Enabled = true;
                checkBox_at9_advband.Enabled = true;
                checkBox_at9_dualenc.Enabled = true;
                checkBox_at9_supframe.Enabled = true;
            }
            else
            {
                enctypeAT9 = "";
                nbandAT9 = "";
                isbandAT9 = "";
                dualencAT9 = "";
                supframeAT9 = "";
                checkBox_at9_enctype.Checked = false;
                checkBox_at9_enctype.Enabled = false;
                checkBox_at9_advband.Checked = false;
                checkBox_at9_advband.Enabled = false;
                checkBox_at9_dualenc.Checked = false;
                checkBox_at9_dualenc.Enabled = false;
                checkBox_at9_supframe.Checked = false;
                checkBox_at9_supframe.Enabled = false;
                comboBox_at9_enctype.Enabled = false;
                comboBox_at9_useband.Enabled = false;
                comboBox_at9_startband.Enabled = false;
                label_at9_enctype.Enabled = false;
                label_at9_startband.Enabled = false;
                label_at9_useband.Enabled = false;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_enctype_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_enctype.Checked != false)
            {
                comboBox_at9_enctype.Enabled = true;
                label_at9_enctype.Enabled = true;
            }
            else
            {
                enctypeAT9 = "";
                comboBox_at9_enctype.Enabled = false;
                label_at9_enctype.Enabled = false;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_dualenc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_dualenc.Checked != false)
            {
                dualencAT9 = " -dual";
            }
            else
            {
                dualencAT9 = "";
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_supframe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_supframe.Checked != false)
            {
                supframeAT9 = " -supframeon";
            }
            else
            {
                supframeAT9 = " -supframeoff";
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void CheckBox_at9_advband_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_at9_advband.Checked != false)
            {
                label_at9_useband.Enabled = true;
                comboBox_at9_useband.Enabled = true;
                label_at9_startband.Enabled = true;
                comboBox_at9_startband.Enabled = true;
            }
            else
            {
                nbandAT9 = "";
                isbandAT9 = "";
                label_at9_useband.Enabled = false;
                comboBox_at9_useband.Enabled = false;
                label_at9_startband.Enabled = false;
                comboBox_at9_startband.Enabled = false;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void ComboBox_at9_useband_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_at9_useband.SelectedIndex)
            {
                case 0:
                    nbandAT9 = " -nbands 3";
                    break;
                case 1:
                    nbandAT9 = " -nbands 4";
                    break;
                case 2:
                    nbandAT9 = " -nbands 5";
                    break;
                case 3:
                    nbandAT9 = " -nbands 6";
                    break;
                case 4:
                    nbandAT9 = " -nbands 7";
                    break;
                case 5:
                    nbandAT9 = " -nbands 8";
                    break;
                case 6:
                    nbandAT9 = " -nbands 9";
                    break;
                case 7:
                    nbandAT9 = " -nbands 10";
                    break;
                case 8:
                    nbandAT9 = " -nbands 11";
                    break;
                case 9:
                    nbandAT9 = " -nbands 12";
                    break;
                case 10:
                    nbandAT9 = " -nbands 13";
                    break;
                case 11:
                    nbandAT9 = " -nbands 14";
                    break;
                case 12:
                    nbandAT9 = " -nbands 15";
                    break;
                case 13:
                    nbandAT9 = " -nbands 16";
                    break;
                case 14:
                    nbandAT9 = " -nbands 17";
                    break;
                case 15:
                    nbandAT9 = " -nbands 18";
                    break;
                default:
                    nbandAT9 = "";
                    break;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void ComboBox_at9_startband_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_at9_startband.SelectedIndex)
            {
                case 0:
                    isbandAT9 = " -isband -1";
                    break;
                case 1:
                    isbandAT9 = " -isband 3";
                    break;
                default:
                    isbandAT9 = "";
                    break;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void ComboBox_at9_enctype_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_at9_enctype.SelectedIndex)
            {
                case 0:
                    enctypeAT9 = " -gradmode 0";
                    break;
                case 1:
                    enctypeAT9 = " -gradmode 1";
                    break;
                case 2:
                    enctypeAT9 = " -gradmode 2";
                    break;
                case 3:
                    enctypeAT9 = " -gradmode 3";
                    break;
                case 4:
                    enctypeAT9 = " -gradmode 4";
                    break;
                case 5:
                    enctypeAT9 = "";
                    break;
                default:
                    enctypeAT9 = "";
                    break;
            }
            paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
            textBox_at9_cmd.Text = paramAT9;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Common.IniFile ini = new(@".\settings.ini");

            if (paramAT3.Contains("$InFile $OutFile") != true || paramAT3.Contains("$InFile") != true || paramAT3.Contains("$OutFile") != true)
            {
                MessageBox.Show(this, Localization.NotFoundIOStringCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                paramAT3 = "at3tool -e" + bitrateAT3 + looppointAT3 + loopstartAT3 + loopendAT3 + wholeloopAT3 + looptimeAT3 + looptimesAT3 + " $InFile $OutFile";
                textBox_at3_cmd.Text = paramAT3;
                return;
            }

            if (paramAT9.Contains("$InFile $OutFile") != true || paramAT9.Contains("$InFile") != true || paramAT9.Contains("$OutFile") != true)
            {
                MessageBox.Show(this, Localization.NotFoundIOStringCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                paramAT9 = "at9tool -e" + bitrateAT9 + samplingAT9 + looppointAT9 + loopstartAT9 + loopendAT9 + wholeloopAT9 + looptimeAT9 + looptimesAT9 + looplistAT9 + looplistfileAT9 + supframeAT9 + dualencAT9 + enctypeAT9 + nbandAT9 + isbandAT9 + " $InFile $OutFile";
                textBox_at9_cmd.Text = paramAT9;
                return;
            }


            if (checkBox_at3_looppoint.Checked != false)
            {
                if (textBox_at3_loopstart.TextLength == 0)
                {
                    MessageBox.Show(this, Localization.LoopStartErrorCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox_at3_loopend.TextLength == 0)
                {
                    MessageBox.Show(this, Localization.LoopEndErrorCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (checkBox_at3_looptimes.Checked != false)
            {
                if (textBox_at3_looptimes.TextLength == 0)
                {
                    MessageBox.Show(this, Localization.LoopTimesErrorCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            if (checkBox_at9_looppoint.Checked != false)
            {
                if (textBox_at9_loopstart.TextLength == 0)
                {
                    MessageBox.Show(this, Localization.LoopStartErrorCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox_at9_loopend.TextLength == 0)
                {
                    MessageBox.Show(this, Localization.LoopEndErrorCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (checkBox_at9_looptimes.Checked != false)
            {
                if (textBox_at9_looptimes.TextLength == 0)
                {
                    MessageBox.Show(this, Localization.LoopTimesErrorCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (checkBox_at9_looplist.Checked != false)
            {
                if (textBox_at9_looplist.TextLength == 0)
                {
                    MessageBox.Show(this, Localization.LoopListErrorCaption, Localization.MSGBoxErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ini.WriteString("ATRAC3_SETTINGS", "Bitrate", comboBox_at3_encmethod.SelectedIndex.ToString());
            ini.WriteString("ATRAC9_SETTINGS", "Bitrate", comboBox_at9_bitrate.SelectedIndex.ToString());
            ini.WriteString("ATRAC9_SETTINGS", "Sampling", comboBox_at9_sampling.SelectedIndex.ToString());

            if (checkBox_at3_loopsound.Checked != false)
            {
                ini.WriteString("ATRAC3_SETTINGS", "LoopSound", "1");
            }
            else
            {
                ini.WriteString("ATRAC3_SETTINGS", "LoopSound", "0");
            }
            if (checkBox_at3_looppoint.Checked != false)
            {
                ini.WriteString("ATRAC3_SETTINGS", "LoopPoint", "1");
                ini.WriteString("ATRAC3_SETTINGS", "LoopStart_Samples", textBox_at3_loopstart.Text);
                ini.WriteString("ATRAC3_SETTINGS", "LoopEnd_Samples", textBox_at3_loopend.Text);
            }
            else
            {
                ini.WriteString("ATRAC3_SETTINGS", "LoopPoint", "0");
                ini.WriteString("ATRAC3_SETTINGS", "LoopStart_Samples", "");
                ini.WriteString("ATRAC3_SETTINGS", "LoopEnd_Samples", "");
            }
            if (checkBox_at3_looptimes.Checked != false)
            {
                ini.WriteString("ATRAC3_SETTINGS", "LoopTime", "1");
                ini.WriteString("ATRAC3_SETTINGS", "LoopTimes", textBox_at3_looptimes.Text);
            }
            else
            {
                ini.WriteString("ATRAC3_SETTINGS", "LoopTime", "0");
                ini.WriteString("ATRAC3_SETTINGS", "LoopTimes", "");
            }

            if (checkBox_at9_loopsound.Checked != false)
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopSound", "1");
            }
            else
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopSound", "0");
            }
            if (checkBox_at9_looppoint.Checked != false)
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopPoint", "1");
                ini.WriteString("ATRAC9_SETTINGS", "LoopStart_Samples", textBox_at9_loopstart.Text);
                ini.WriteString("ATRAC9_SETTINGS", "LoopEnd_Samples", textBox_at9_loopend.Text);
            }
            else
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopPoint", "0");
                ini.WriteString("ATRAC9_SETTINGS", "LoopStart_Samples", "");
                ini.WriteString("ATRAC9_SETTINGS", "LoopEnd_Samples", "");
            }
            if (checkBox_at9_looptimes.Checked != false)
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopTime", "1");
                ini.WriteString("ATRAC9_SETTINGS", "LoopTimes", textBox_at9_looptimes.Text);
            }
            else
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopTime", "0");
                ini.WriteString("ATRAC9_SETTINGS", "LoopTimes", "");
            }
            if (checkBox_at9_looplist.Checked != false)
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopList", "1");
                ini.WriteString("ATRAC9_SETTINGS", "LoopListFile", textBox_at9_looplist.Text);
            }
            else
            {
                ini.WriteString("ATRAC9_SETTINGS", "LoopList", "0");
                ini.WriteString("ATRAC9_SETTINGS", "LoopListFile", "");
            }
            if (checkBox_at9_advanced.Checked != false)
            {
                ini.WriteString("ATRAC9_SETTINGS", "Advanced", "1");
                if (checkBox_at9_enctype.Checked != false)
                {
                    ini.WriteString("ATRAC9_SETTINGS", "EncodeType", "1");
                    ini.WriteString("ATRAC9_SETTINGS", "EncodeTypeIndex", comboBox_at9_enctype.SelectedIndex.ToString());
                }
                else
                {
                    ini.WriteString("ATRAC9_SETTINGS", "EncodeType", "0");
                    ini.WriteString("ATRAC9_SETTINGS", "EncodeTypeIndex", "");
                }
                if (checkBox_at9_advband.Checked != false)
                {
                    ini.WriteString("ATRAC9_SETTINGS", "AdvanceBand", "1");
                    ini.WriteString("ATRAC9_SETTINGS", "NbandsIndex", comboBox_at9_useband.SelectedIndex.ToString());
                    ini.WriteString("ATRAC9_SETTINGS", "IsbandIndex", comboBox_at9_startband.SelectedIndex.ToString());
                }
                else
                {
                    ini.WriteString("ATRAC9_SETTINGS", "AdvanceBand", "0");
                    ini.WriteString("ATRAC9_SETTINGS", "NbandsIndex", "");
                    ini.WriteString("ATRAC9_SETTINGS", "IsbandIndex", "");
                }
                if (checkBox_at9_dualenc.Checked != false)
                {
                    ini.WriteString("ATRAC9_SETTINGS", "DualEncode", "1");
                }
                else
                {
                    ini.WriteString("ATRAC9_SETTINGS", "DualEncode", "0");
                }
                if (checkBox_at9_supframe.Checked != false)
                {
                    ini.WriteString("ATRAC9_SETTINGS", "SuperFrameEncode", "1");
                }
                else
                {
                    ini.WriteString("ATRAC9_SETTINGS", "SuperFrameEncode", "0");
                }
            }
            else
            {
                ini.WriteString("ATRAC9_SETTINGS", "Advanced", "0");
                ini.WriteString("ATRAC9_SETTINGS", "EncodeType", "0");
                ini.WriteString("ATRAC9_SETTINGS", "EncodeTypeIndex", "");
                ini.WriteString("ATRAC9_SETTINGS", "AdvanceBand", "0");
                ini.WriteString("ATRAC9_SETTINGS", "NbandsIndex", "");
                ini.WriteString("ATRAC9_SETTINGS", "IsbandIndex", "");
                ini.WriteString("ATRAC9_SETTINGS", "DualEncode", "0");
                ini.WriteString("ATRAC9_SETTINGS", "SuperFrameEncode", "0");
            }

            ini.WriteString("ATRAC3_SETTINGS", "Param", paramAT3);
            ini.WriteString("ATRAC9_SETTINGS", "Param", paramAT9);

            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
