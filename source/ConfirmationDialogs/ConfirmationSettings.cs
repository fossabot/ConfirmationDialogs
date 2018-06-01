﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace ConfirmationDialogs {
	public static class ConfirmationSettings {
		public static Dictionary<ModifierKeys, ModifierRequirement> Requirements {
			get => Confirmation.Requirements;
			set {
				foreach (KeyValuePair<ModifierKeys, ModifierRequirement> modifierRequirement in value) {
					if (Confirmation.Requirements.ContainsKey(modifierRequirement.Key)) {
						Confirmation.Requirements[modifierRequirement.Key] = modifierRequirement.Value;
					}
				}
			}
		}

		public static bool Skip {
			set => Confirmation.Skip = value;
		}

		public static bool AllowSkip {
			set => Confirmation.AllowSkip = value;
		}

		public static ModifierRequirement Alt {
			set => Confirmation.Requirements[ModifierKeys.Alt] = value;
		}

		public static ModifierRequirement Shift {
			set => Confirmation.Requirements[ModifierKeys.Shift] = value;
		}

		public static ModifierRequirement Control {
			set => Confirmation.Requirements[ModifierKeys.Control] = value;
		}

		public static ModifierRequirement Windows {
			set => Confirmation.Requirements[ModifierKeys.Windows] = value;
		}
	}
}