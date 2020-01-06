/*
 *	This program is the CONFIDENTIAL and PROPRIETARY property 
 *	of Tomasello Software LLC. Any unauthorized use, reproduction or
 *	transfer of this computer program is strictly prohibited.
 *
 *      Copyright (c) 2004 Tomasello Software LLC.
 *	This is an unpublished work, and is subject to limited distribution and
 *	restricted disclosure only. ALL RIGHTS RESERVED.
 *
 *			RESTRICTED RIGHTS LEGEND
 *	Use, duplication, or disclosure by the Government is subject to
 *	restrictions set forth in subparagraph (c)(1)(ii) of the Rights in
 * 	Technical Data and Computer Software clause at DFARS 252.227-7013.
 *
 *	Angel Island UO Shard	Version 1.0
 *			Release A
 *			March 25, 2004
 */

using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BagOfAllReagents : Bag
	{
		[Constructable]
		public BagOfAllReagents()
			: this(50)
		{
		}

		[Constructable]
		public BagOfAllReagents(int amount)
		{
			DropItem(new BlackPearl(amount));
			DropItem(new Bloodmoss(amount));
			DropItem(new Garlic(amount));
			DropItem(new Ginseng(amount));
			DropItem(new MandrakeRoot(amount));
			DropItem(new Nightshade(amount));
			DropItem(new SulfurousAsh(amount));
			DropItem(new SpidersSilk(amount));
			DropItem(new BatWing(amount));
			DropItem(new GraveDust(amount));
			DropItem(new DaemonBlood(amount));
			DropItem(new NoxCrystal(amount));
			DropItem(new PigIron(amount));
		}

		public BagOfAllReagents(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}