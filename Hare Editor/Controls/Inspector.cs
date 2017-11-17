using System.Windows.Forms;
using System.Collections.Generic;
using OpenTK;
using HareEngine;
using System.Reflection;
using System;

namespace HareEditor {

    public class Inspector : DBPanel {

        private List<Control> toAdd = new List<Control>();

        public void Reload() {
            Controls.Clear();
            if (Program.editor.SelectedGameObject != null) {
                DBPanel pnlInfo = new DBPanel();
                TextBox tbxName = new TextBox();
                DBPanel pnlTag = new DBPanel();
                Label lblTag = new Label();
                TextBox tbxTag = new TextBox();
                DBPanel pnlPosition = new DBPanel();
                Label lblPos = new Label();
                Label lblPosX = new Label();
                NumericUpDown tbxPosX = new NumericUpDown();
                Label lblPosY = new Label();
                NumericUpDown tbxPosY = new NumericUpDown();
                Label lblPosZ = new Label();
                NumericUpDown tbxPosZ = new NumericUpDown();
                DBPanel pnlRotation = new DBPanel();
                Label lblRot = new Label();
                Label lblRotX = new Label();
                NumericUpDown tbxRotX = new NumericUpDown();
                Label lblRotY = new Label();
                NumericUpDown tbxRotY = new NumericUpDown();
                Label lblRotZ = new Label();
                NumericUpDown tbxRotZ = new NumericUpDown();
                DBPanel pnlScale = new DBPanel();
                Label lblScale = new Label();
                Label lblScaleX = new Label();
                NumericUpDown tbxScaleX = new NumericUpDown();
                Label lblScaleY = new Label();
                NumericUpDown tbxScaleY = new NumericUpDown();
                Label lblScaleZ = new Label();
                NumericUpDown tbxScaleZ = new NumericUpDown();
                pnlInfo.BackColor = System.Drawing.Color.FromArgb(128, 128, 128, 128);
                pnlInfo.Controls.Add(pnlScale);
                pnlInfo.Controls.Add(lblScale);
                pnlInfo.Controls.Add(pnlRotation);
                pnlInfo.Controls.Add(lblRot);
                pnlInfo.Controls.Add(pnlPosition);
                pnlInfo.Controls.Add(lblPos);
                pnlInfo.Controls.Add(pnlTag);
                pnlInfo.Controls.Add(tbxName);
                pnlInfo.Dock = DockStyle.Top;
                pnlInfo.Size = new System.Drawing.Size(200, 160);

                tbxName.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                tbxName.Dock = DockStyle.Top;
                tbxName.ForeColor = System.Drawing.Color.FromArgb(15, 15, 15);
                tbxName.Text = Program.editor.SelectedGameObject.Name;
                tbxName.TextChanged += (o, e) => {
                    Program.editor.SelectedGameObject.Name = tbxName.Text;
                    Program.editor.Hierarchy.Reload();
                };

                pnlTag.Dock = DockStyle.Top;
                pnlTag.Size = new System.Drawing.Size(200, 20);
                pnlTag.Controls.Add(tbxTag);
                pnlTag.Controls.Add(lblTag);

                lblTag.Dock = DockStyle.Left;
                lblTag.Size = new System.Drawing.Size(32, 20);
                lblTag.Text = "Tag";
                lblTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lblTag.ForeColor = Program.colorFont;

                tbxTag.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                tbxTag.Dock = DockStyle.Fill;
                tbxTag.ForeColor = System.Drawing.Color.FromArgb(15, 15, 15);
                tbxTag.Text = Program.editor.SelectedGameObject.Tag;
                tbxTag.TextChanged += (o, e) => {
                    Program.editor.SelectedGameObject.Tag = tbxTag.Text;
                };

                pnlPosition.Dock = DockStyle.Top;
                pnlPosition.Height = 20;
                pnlPosition.Controls.Add(tbxPosZ);
                pnlPosition.Controls.Add(lblPosZ);
                pnlPosition.Controls.Add(tbxPosY);
                pnlPosition.Controls.Add(lblPosY);
                pnlPosition.Controls.Add(tbxPosX);
                pnlPosition.Controls.Add(lblPosX);

                tbxPosX.Dock = DockStyle.Left;
                tbxPosX.Width = 48;
                tbxPosX.DecimalPlaces = 8;
                tbxPosX.Minimum = decimal.MinValue;
                tbxPosX.Maximum = decimal.MaxValue;
                tbxPosX.Value = (decimal)Program.editor.SelectedGameObject.transform.position.X;
                tbxPosX.ValueChanged += (o, e) => {
                    Vector3 pos = Program.editor.SelectedGameObject.transform.position;
                    Program.editor.SelectedGameObject.transform.position = new Vector3(
                        (float)tbxPosX.Value,
                        pos.Y,
                        pos.Z
                        );
                };
                tbxPosY.Dock = DockStyle.Left;
                tbxPosY.Width = 48;
                tbxPosY.DecimalPlaces = 8;
                tbxPosY.Minimum = decimal.MinValue;
                tbxPosY.Maximum = decimal.MaxValue;
                tbxPosY.Value = (decimal)Program.editor.SelectedGameObject.transform.position.Y;
                tbxPosY.ValueChanged += (o, e) => {
                    Vector3 pos = Program.editor.SelectedGameObject.transform.position;
                    Program.editor.SelectedGameObject.transform.position = new Vector3(
                        pos.X,
                        (float)tbxPosY.Value,
                        pos.Z
                        );
                };
                tbxPosZ.Dock = DockStyle.Left;
                tbxPosZ.Width = 48;
                tbxPosZ.DecimalPlaces = 8;
                tbxPosZ.Minimum = decimal.MinValue;
                tbxPosZ.Maximum = decimal.MaxValue;
                tbxPosZ.Value = (decimal)Program.editor.SelectedGameObject.transform.position.Z;
                tbxPosZ.ValueChanged += (o, e) => {
                    Vector3 pos = Program.editor.SelectedGameObject.transform.position;
                    Program.editor.SelectedGameObject.transform.position = new Vector3(
                        pos.X,
                        pos.Y,
                        (float)tbxPosZ.Value
                        );
                };

                lblPos.Text = "Position";
                lblPos.Dock = DockStyle.Top;
                lblPos.ForeColor = Program.colorFont;
                lblPos.Height = 20;
                lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblPosX.Text = "X:";
                lblPosX.Dock = DockStyle.Left;
                lblPosX.ForeColor = Program.colorFont;
                lblPosX.Width = 17;
                lblPosX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblPosY.Text = "Y:";
                lblPosY.Dock = DockStyle.Left;
                lblPosY.ForeColor = Program.colorFont;
                lblPosY.Width = 17;
                lblPosY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblPosZ.Text = "Z:";
                lblPosZ.Dock = DockStyle.Left;
                lblPosZ.ForeColor = Program.colorFont;
                lblPosZ.Width = 17;
                lblPosZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                pnlRotation.Dock = DockStyle.Top;
                pnlRotation.Height = 20;
                pnlRotation.Controls.Add(tbxRotZ);
                pnlRotation.Controls.Add(lblRotZ);
                pnlRotation.Controls.Add(tbxRotY);
                pnlRotation.Controls.Add(lblRotY);
                pnlRotation.Controls.Add(tbxRotX);
                pnlRotation.Controls.Add(lblRotX);

                tbxRotX.Dock = DockStyle.Left;
                tbxRotX.Width = 48;
                tbxRotX.DecimalPlaces = 8;
                tbxRotX.Minimum = decimal.MinValue;
                tbxRotX.Maximum = decimal.MaxValue;
                tbxRotX.Value = (decimal)Program.editor.SelectedGameObject.transform.rotation.X;
                tbxRotX.ValueChanged += (o, e) => {
                    Quaternion rot = Program.editor.SelectedGameObject.transform.rotation;
                    Program.editor.SelectedGameObject.transform.rotation = Quaternion.FromEulerAngles(
                        (float)tbxRotX.Value,
                        (float)tbxRotY.Value,
                        (float)tbxRotZ.Value
                        );
                };
                tbxRotY.Dock = DockStyle.Left;
                tbxRotY.Width = 48;
                tbxRotY.DecimalPlaces = 8;
                tbxRotY.Minimum = decimal.MinValue;
                tbxRotY.Maximum = decimal.MaxValue;
                tbxRotY.Value = (decimal)Program.editor.SelectedGameObject.transform.rotation.Y;
                tbxRotY.ValueChanged += (o, e) => {
                    Quaternion rot = Program.editor.SelectedGameObject.transform.rotation;
                    Program.editor.SelectedGameObject.transform.rotation = Quaternion.FromEulerAngles(
                        (float)tbxRotX.Value,
                        (float)tbxRotY.Value,
                        (float)tbxRotZ.Value
                        );
                };
                tbxRotZ.Dock = DockStyle.Left;
                tbxRotZ.Width = 48;
                tbxRotZ.DecimalPlaces = 8;
                tbxRotZ.Minimum = decimal.MinValue;
                tbxRotZ.Maximum = decimal.MaxValue;
                tbxRotZ.Value = (decimal)Program.editor.SelectedGameObject.transform.rotation.Z;
                tbxRotZ.ValueChanged += (o, e) => {
                    Quaternion rot = Program.editor.SelectedGameObject.transform.rotation;
                    Program.editor.SelectedGameObject.transform.rotation = Quaternion.FromEulerAngles(
                        (float)tbxRotX.Value,
                        (float)tbxRotY.Value,
                        (float)tbxRotZ.Value
                        );
                };

                lblRot.Text = "Rotation";
                lblRot.Dock = DockStyle.Top;
                lblRot.ForeColor = Program.colorFont;
                lblRot.Height = 20;
                lblRot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblRotX.Text = "X:";
                lblRotX.Dock = DockStyle.Left;
                lblRotX.ForeColor = Program.colorFont;
                lblRotX.Width = 17;
                lblRotX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblRotY.Text = "Y:";
                lblRotY.Dock = DockStyle.Left;
                lblRotY.ForeColor = Program.colorFont;
                lblRotY.Width = 17;
                lblRotY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblRotZ.Text = "Z:";
                lblRotZ.Dock = DockStyle.Left;
                lblRotZ.ForeColor = Program.colorFont;
                lblRotZ.Width = 17;
                lblRotZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                pnlScale.Dock = DockStyle.Top;
                pnlScale.Height = 20;
                pnlScale.Controls.Add(tbxScaleZ);
                pnlScale.Controls.Add(lblScaleZ);
                pnlScale.Controls.Add(tbxScaleY);
                pnlScale.Controls.Add(lblScaleY);
                pnlScale.Controls.Add(tbxScaleX);
                pnlScale.Controls.Add(lblScaleX);

                tbxScaleX.Dock = DockStyle.Left;
                tbxScaleX.Width = 48;
                tbxScaleX.DecimalPlaces = 8;
                tbxScaleX.Minimum = decimal.MinValue;
                tbxScaleX.Maximum = decimal.MaxValue;
                tbxScaleX.Value = (decimal)Program.editor.SelectedGameObject.transform.scale.X;
                tbxScaleX.ValueChanged += (o, e) => {
                    Vector3 scale = Program.editor.SelectedGameObject.transform.scale;
                    Program.editor.SelectedGameObject.transform.scale = new Vector3(
                        (float)tbxScaleX.Value,
                        scale.Y,
                        scale.Z
                        );
                };
                tbxScaleY.Dock = DockStyle.Left;
                tbxScaleY.Width = 48;
                tbxScaleY.DecimalPlaces = 8;
                tbxScaleY.Minimum = decimal.MinValue;
                tbxScaleY.Maximum = decimal.MaxValue;
                tbxScaleY.Value = (decimal)Program.editor.SelectedGameObject.transform.scale.Y;
                tbxScaleY.ValueChanged += (o, e) => {
                    Vector3 scale = Program.editor.SelectedGameObject.transform.scale;
                    Program.editor.SelectedGameObject.transform.scale = new Vector3(
                        scale.X,
                        (float)tbxScaleY.Value,
                        scale.Z
                        );
                };
                tbxScaleZ.Dock = DockStyle.Left;
                tbxScaleZ.Width = 48;
                tbxScaleZ.DecimalPlaces = 8;
                tbxScaleZ.Minimum = decimal.MinValue;
                tbxScaleZ.Maximum = decimal.MaxValue;
                tbxScaleZ.Value = (decimal)Program.editor.SelectedGameObject.transform.scale.Z;
                tbxScaleZ.ValueChanged += (o, e) => {
                    Vector3 scale = Program.editor.SelectedGameObject.transform.scale;
                    Program.editor.SelectedGameObject.transform.scale = new Vector3(
                        scale.X,
                        scale.Y,
                        (float)tbxScaleZ.Value
                        );
                };

                lblScale.Text = "Scale";
                lblScale.Dock = DockStyle.Top;
                lblScale.ForeColor = Program.colorFont;
                lblScale.Height = 20;
                lblScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblScaleX.Text = "X:";
                lblScaleX.Dock = DockStyle.Left;
                lblScaleX.ForeColor = Program.colorFont;
                lblScaleX.Width = 17;
                lblScaleX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblScaleY.Text = "Y:";
                lblScaleY.Dock = DockStyle.Left;
                lblScaleY.ForeColor = Program.colorFont;
                lblScaleY.Width = 17;
                lblScaleY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblScaleZ.Text = "Z:";
                lblScaleZ.Dock = DockStyle.Left;
                lblScaleZ.ForeColor = Program.colorFont;
                lblScaleZ.Width = 17;
                lblScaleZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                toAdd.Add(pnlInfo);
                PrintBehaviours();
            }

            for (int i = toAdd.Count - 1; i >= 0; i--) {
                Controls.Add(toAdd[i]);
            }
            toAdd.Clear();
        }

        private void PrintBehaviours() {
            foreach (Behaviour b in Program.editor.SelectedGameObject.behaviours) {
                Label label = new Label();
                label.Text = b.GetType().Name;
                label.ForeColor = Program.colorFont;
                label.BackColor = Program.colorAccent;
                label.Dock = DockStyle.Top;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.Height = 24;
                toAdd.Add(label);
                foreach (FieldInfo prop in b.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public)) {
                    try {
                        TypeSwitch ts = new TypeSwitch()
                            .Case<string>(() => {
                                StringField panel = new StringField();
                                panel.Height = 24;
                                panel.Dock = DockStyle.Top;
                                panel.Text = prop.Name;
                                panel.Value = (string)prop.GetValue(b);
                                panel.FontColor = Program.colorFont;
                                panel.ValueChanged += (o, e) => {
                                    prop.SetValue(b, panel.Value);
                                };
                                toAdd.Add(panel);
                            })
                            .Case<int>(() => {
                                NumberField panel = new NumberField();
                                panel.Height = 24;
                                panel.Dock = DockStyle.Top;
                                panel.Text = prop.Name;
                                panel.Value = (int)prop.GetValue(b);
                                panel.FontColor = Program.colorFont;
                                panel.ValueChanged += (o, e) => {
                                    prop.SetValue(b, (int)panel.Value);
                                };
                                toAdd.Add(panel);
                            })
                            .Case<float>(() => {
                                NumberField panel = new NumberField();
                                panel.Height = 24;
                                panel.Dock = DockStyle.Top;
                                panel.Text = prop.Name;
                                panel.Value = (decimal)(float)prop.GetValue(b);
                                panel.FontColor = Program.colorFont;
                                panel.ValueChanged += (o, e) => {
                                    prop.SetValue(b, (float)panel.Value);
                                };
                                toAdd.Add(panel);
                            })
                            .Case<double>(() => {
                                NumberField panel = new NumberField();
                                panel.Height = 24;
                                panel.Dock = DockStyle.Top;
                                panel.Text = prop.Name;
                                panel.Value = (decimal)(double)prop.GetValue(b);
                                panel.FontColor = Program.colorFont;
                                panel.ValueChanged += (o, e) => {
                                    prop.SetValue(b, (double)panel.Value);
                                };
                                toAdd.Add(panel);
                            })
                            .Case<bool>(() => {
                                DBPanel panel = new DBPanel();
                                panel.Height = 24;
                                panel.Dock = DockStyle.Top;
                                CheckBox cbxValue = new CheckBox();
                                panel.Controls.Add(cbxValue);
                                cbxValue.Text = prop.Name;
                                cbxValue.Checked = (bool)prop.GetValue(b);
                                cbxValue.AutoSize = false;
                                cbxValue.Dock = DockStyle.Fill;
                                cbxValue.ForeColor = Program.colorFont;
                                cbxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                                cbxValue.Dock = DockStyle.Left;
                                cbxValue.CheckedChanged += (o, e) => {
                                    prop.SetValue(b, cbxValue.Checked);
                                };
                                toAdd.Add(panel);
                            })
                            .Case<Color>(() => {
                                ColorField panel = new ColorField();
                                panel.Dock = DockStyle.Top;
                                panel.Text = prop.Name;
                                panel.FontColor = Program.colorFont;
                                panel.Color = Program.HareColorToNETColor((Color)prop.GetValue(b));
                                panel.Click += (o, e) => {
                                    ColorSelector.Prompt(panel.Text, panel.Color, (color) => {
                                        prop.SetValue(b, color);
                                        panel.Color = Program.HareColorToNETColor(color);
                                    });
                                };
                                toAdd.Add(panel);
                            })
                            .Case<HareEngine.Texture>(() => {
                                TextureField panel = new TextureField();
                                panel.Height = 24;
                                panel.Dock = DockStyle.Top;
                                panel.Text = prop.Name;
                                panel.FontColor = Program.colorFont;
                                panel.Texture = ((Texture)prop.GetValue(b)).FilePath;
                                panel.Click += (o, e) => {
                                    ImagePrompt.Prompt(panel.Text, (tex) => {
                                        Texture texture = HareEngine.Asset.Get<Texture>(tex);
                                        if (texture != null) {
                                            prop.SetValue(b, texture);
                                            panel.Texture = texture.FilePath;
                                        } else {
                                            MessageBox.Show(tex);
                                        }
                                    });
                                };
                                toAdd.Add(panel);
                            })
                            .Default(() => {
                                //TODO handle different types
                            });
                        ts.Switch(prop.GetValue(b).GetType());
                    } catch (Exception e){
                        Debug.Error(e.Message);
                    }
                }
            }
        }

    }

}
