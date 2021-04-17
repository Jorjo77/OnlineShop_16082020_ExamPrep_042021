
using OnlineShop.Common.Constants;
using OnlineShop.Common.Enums;
using OnlineShop.Models.Products;
using OnlineShop.Models.Products.Computers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Component = OnlineShop.Models.Products.Component;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computers;
        private List<Component> components;
        private List<Peripheral> peripherals;

        public Controller()
        {
            computers = new List<IComputer>();
            components = new List<Component>();
            peripherals = new List<Peripheral>();
        }

        public IReadOnlyCollection<IComputer> Computers
            => computers.AsReadOnly();

        public IReadOnlyCollection<Component> Components
            => components.AsReadOnly();

        public IReadOnlyCollection<Peripheral> Peripherals
            => peripherals.AsReadOnly();

        public string AddComponent
            (int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            
            if (computers.Any(c=>c.Id == id))
            {
                bool IsValidType = Enum.TryParse<ComponentType>(componentType, out ComponentType componType);
                if (IsValidType)
                {
                    Component component = null;
                    string message = string.Empty;

                    switch (componType)
                    {
                        case ComponentType.CentralProcessingUnit:
                            component = new CentralProcessingUnit(overallPerformance, price, model,manufacturer, id, generation);
                            if (components.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
                            }
                            else
                            {
                                components.Add(component);
                                message = string.Format(SuccessMessages.AddedComponent, id);
                            }
                            break;

                        case ComponentType.Motherboard:
                            component = new Motherboard(overallPerformance, price, model, manufacturer, id, generation);
                            if (components.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
                            }
                            else
                            {
                                components.Add(component);
                                message = string.Format(SuccessMessages.AddedComponent, id);
                            }
                            break;
                        case ComponentType.PowerSupply:
                            component = new PowerSupply(overallPerformance, price, model, manufacturer, id, generation);
                            if (components.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
                            }
                            else
                            {
                                components.Add(component);
                                message = string.Format(SuccessMessages.AddedComponent, id);
                            }
                            break;
                        case ComponentType.RandomAccessMemory:
                            component = new RandomAccessMemory(overallPerformance, price, model, manufacturer, id, generation);
                            if (components.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
                            }
                            else
                            {
                                components.Add(component);
                                message = string.Format(SuccessMessages.AddedComponent, id);
                            }
                            break;
                        case ComponentType.SolidStateDrive:
                            component = new SolidStateDrive(overallPerformance, price, model, manufacturer, id, generation);
                            if (components.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
                            }
                            else
                            {
                                components.Add(component);
                                message = string.Format(SuccessMessages.AddedComponent, id);
                            }
                            break;
                        case ComponentType.VideoCard:
                            component = new VideoCard(overallPerformance, price, model, manufacturer, id, generation);
                            if (components.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
                            }
                            else
                            {
                                components.Add(component);
                                message = string.Format(SuccessMessages.AddedComponent, id);
                            }
                            break;
                        default:
                            break;
                    }

                    return message;

                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidComponentType);
                }
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {

            bool IsValidType = Enum.TryParse<ComputerType>(computerType, out ComputerType compType);
            if (IsValidType)
            {
                IComputer computer = null;
                string message = string.Empty;
                switch (compType)
                {
                    case ComputerType.DesktopComputer:
                        computer = new DesktopComputer(price, model, manufacturer, id);
                        if (computers.Any(c=>c.Id== id))
                        {
                            throw new ArgumentException(ExceptionMessages.ExistingComputerId);
                        }
                        else
                        {
                            computers.Add(computer);
                            message = string.Format(SuccessMessages.AddedComputer, id);
                        }
                        break;
                    case ComputerType.Laptop:
                        computer = new Laptop(price, model, manufacturer, id);
                        if (computers.Any(c => c.Id == id))
                        {
                            throw new ArgumentException(ExceptionMessages.ExistingComputerId);
                        }
                        else
                        {
                            computers.Add(computer);
                            message = string.Format(SuccessMessages.AddedComputer, id);
                        }
                        break;

                    default:
                        break;
                }

                return message;

            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }

        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {

            if (computers.Any(c => c.Id == id))
            {
                bool IsValidType = Enum.TryParse<PeripheralType>(peripheralType, out PeripheralType periphType);
                if (IsValidType)
                {
                    Peripheral peripheral = null;
                    string message = string.Empty;

                    switch (periphType)
                    {
                        case PeripheralType.Headset:
                            peripheral = new Headset(overallPerformance, price, model, manufacturer, id, connectionType);
                            if (peripherals.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
                            }
                            else
                            {
                                peripherals.Add(peripheral);
                                message = string.Format(SuccessMessages.AddedPeripheral, id);
                            }
                            break;
                        case PeripheralType.Keyboard:
                            peripheral = new Keyboard(overallPerformance, price, model, manufacturer, id, connectionType);
                            if (peripherals.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
                            }
                            else
                            {
                                peripherals.Add(peripheral);
                                message = string.Format(SuccessMessages.AddedPeripheral, id);
                            }
                            break;
                        case PeripheralType.Monitor:
                            peripheral = new Monitor(overallPerformance, price, model, manufacturer, id, connectionType);
                            if (peripherals.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
                            }
                            else
                            {
                                peripherals.Add(peripheral);
                                message = string.Format(SuccessMessages.AddedPeripheral, id);
                            }
                            break;
                        case PeripheralType.Mouse:
                            peripheral = new Mouse(overallPerformance, price, model, manufacturer, id, connectionType);
                            if (peripherals.Any(c => c.Id == id))
                            {
                                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
                            }
                            else
                            {
                                peripherals.Add(peripheral);
                                message = string.Format(SuccessMessages.AddedPeripheral, id);
                            }
                            break;
                        default:
                            break;
                    }

                    return message;

                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
                }
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }

        public string BuyBest(decimal budget)
        {
            var bestAfordableComputer = computers.Where(c => c.Price <= budget).OrderByDescending(c => c.OverallPerformance).First();
            if (bestAfordableComputer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }
            else
            {
                return bestAfordableComputer.ToString();
            }
        }

        public string BuyComputer(int id)
        {
            if (computers.Any(c => c.Id == id))
            {
                var searchedComputer = computers.FirstOrDefault(c => c.Id == id);
                computers.Remove(searchedComputer);
                return searchedComputer.ToString();
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }

        public string GetComputerData(int id)
        {

            string message = string.Empty;
            if (computers.Any(c => c.Id == id))
            {
                var searchedComputer = computers.FirstOrDefault(c => c.Id == id);
                return searchedComputer.ToString();
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }

        public string RemoveComponent(string componentType, int computerId)
        {

            string message = string.Empty;
            if (computers.Any(c => c.Id == computerId))
            {
                bool IsValidType = Enum.TryParse<ComponentType>(componentType, out ComponentType componType);
                if (IsValidType)
                {
                    var searchedComputer = computers.FirstOrDefault(c => c.Id == computerId);
                    var searchedComponent = components.First(c => c.GetType().Name == componentType);
                    searchedComputer.RemoveComponent(componentType);
                    components.Remove(searchedComponent);
                    message = string.Format(SuccessMessages.RemovedComponent, componentType, searchedComponent.Id);
                }
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            return message;

        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            string message = string.Empty;
            if (computers.Any(c => c.Id == computerId))
            {
                bool IsValidType = Enum.TryParse<PeripheralType>(peripheralType, out PeripheralType periphType);
                if (IsValidType)
                {
                    var searchedComputer = computers.FirstOrDefault(c => c.Id == computerId);
                    var searchedPeripheral = peripherals.First(c => c.GetType().Name == peripheralType);
                    searchedComputer.RemovePeripheral(peripheralType);
                    peripherals.Remove(searchedPeripheral);
                    message = string.Format(SuccessMessages.RemovedPeripheral, peripheralType, searchedPeripheral.Id);
                }
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            return message;

        }
    }
}
